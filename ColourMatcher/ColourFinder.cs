using ColourMatcher.Site.Code;
using System;
using System.Collections.Concurrent;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ColourMatcher;

internal class ColourFinder
{


    public static async Task GenerateColourMatches()
    {
        var items = JsonSerializer.Deserialize<IEnumerable<Colour>>(await File.ReadAllTextAsync("C:\\Source\\Prototyping\\ColourMatcher\\ColourMatcher\\colours.json"))!.ToFrozenSet();

        var files = Directory.GetFiles("C:\\Source\\Prototyping\\ColourMatcher\\ColourMatcher\\Bands");

        var results = new ConcurrentDictionary<string, IEnumerable<Match>>();



        Parallel.ForEach(files, s =>
        {
            var matches = ColourMatcher.ColourFinder.FindFor(items, s);

            var filename = Path.GetFileNameWithoutExtension(s);

            results.TryAdd(filename, matches);
        });


        var toStore = results.ToDictionary(i => i.Key,
            i => i.Value.Select(j => new MinimalMatch { X = j.X, Distance = j.Distance, ColourId = j.PaintColour.Id }));

        var usedColour = results.SelectMany(i => i.Value).Select(i => i.PaintColour).DistinctBy(i => i.Id).ToArray();

        var store = new Store()
        {
            Matches = toStore,
            Colours = usedColour
        };


        var resultPath = "C:\\Source\\Prototyping\\ColourMatcher\\ColourMatcher\\matches.json";

        if (File.Exists(resultPath))
            File.Delete(resultPath);

        await File.WriteAllTextAsync(resultPath, JsonSerializer.Serialize(store));
    }


    public static async Task DefineCode()
    {

        var items = JsonSerializer.Deserialize<Store>(await File.ReadAllTextAsync("C:\\Source\\Prototyping\\ColourMatcher\\ColourMatcher\\matches.json"));

        var code2 = $@"
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ColourMatcher.Site.Code;

public partial class PairedColours
{{

    public static IEnumerable<string> Filenames => Boundaries.Filenames;

    public static IEnumerable<PairedColour> GetFor(string filename)
    {{

        {string.Join(Environment.NewLine+Environment.NewLine, Boundaries.Filenames.Select(i => $"if (filename.Equals(nameof({i}), StringComparison.CurrentCultureIgnoreCase)) return {i};"))}

        return Array.Empty<PairedColour>();
    }}

}}";



        var colourLines = items.Colours.Select(i =>
            $@"new MatchedColour(Guid.Parse(""{i.Id}""), Color.FromArgb({i.Red}, {i.Green}, {i.Blue}), ""{i.Code}"", ""{i.Name}"", ColourSource.{i.ColourSource.ToString()}),");

        var pairedColorCode = $@"
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ColourMatcher.Site.Code;

public partial class MatchedColours
{{
    public static MatchedColour Lookup(Guid id) {{ 
        var c = Items.FirstOrDefault(i => i.Id == id); 
        return c!;
    }}

    public static readonly IEnumerable<MatchedColour> Items =
     [
{string.Join(Environment.NewLine, colourLines)}
];
}}";


        await WriteFile("C:\\Source\\Prototyping\\ColourMatcher\\ColourMatcher\\CodeGen\\MatchedColours.cs", pairedColorCode);


        


        await WriteFile("C:\\Source\\Prototyping\\ColourMatcher\\ColourMatcher\\CodeGen\\PairedColours.cs", code2);

        foreach (var item in items.Matches.OrderBy(i => i.Key))
        {
            var filename = Boundaries.Filenames.First(i => i.Equals(item.Key, StringComparison.InvariantCultureIgnoreCase));

            var image = Image.FromFile($"C:\\Source\\Prototyping\\ColourMatcher\\ColourMatcher\\Bands\\{filename}.png");

            var lines = item.Value.Select(i => $@"new PairedColour({i.X},{i.Distance}, {i.X / (decimal)image.Width}m, MatchedColours.Lookup(Guid.Parse(""{i.ColourId}""))),");

            var fileCode = $@"
using System;
using System.Collections.Generic;

namespace ColourMatcher.Site.Code;

public partial class PairedColours
{{
    private static readonly IEnumerable<PairedColour> {filename} = [
{string.Join(Environment.NewLine, lines)}
];
}}";


            await WriteFile($"C:\\Source\\Prototyping\\ColourMatcher\\ColourMatcher\\CodeGen\\PairedColours.{filename}.cs", fileCode);
        }

    }


    private static async Task WriteFile(string path, string content)
    {

        if(File.Exists(path))
            File.Delete(path);

        await File.WriteAllTextAsync(path, content);
    }



    public static IEnumerable<Match> FindFor(IEnumerable<Colour> paintColours, string filePath)
    {
        var image = Image.FromFile(filePath);
        var bitmap = new Bitmap(image);


        var pixels = Enumerable.Range(0, bitmap.Width - 1).Select(i => new Pixel(i, bitmap.GetPixel(i,0))).ToArray();

        var sw = new Stopwatch();
        sw.Start();

        var matches = new ConcurrentBag<Match>();

        var tolerance = 0;
        var maxDistanceBetweenMatches = 100;
        do
        {
            FindWithTolerance(pixels, paintColours, matches, tolerance);
            tolerance += 10;

            var closest = matches.GroupBy(i => i.X).Select(i => i.MinBy(i => i.AbsDistance)!).OrderBy(i=>i.X).ToArray();

            matches.Clear();
            foreach (var c in closest)
                matches.Add(c);


            if(!matches.Any())
                continue;

            var distance = 0;

            var furthestRight = matches.MaxBy(i => i.X)!;

            distance = bitmap.Width - furthestRight.X;
            
            if(distance > maxDistanceBetweenMatches)
                continue;


            Match? lastMatch = null;
            foreach (var c in closest.GroupBy(i => i.PaintColour).Select(i=>i.MinBy(j=>j.X)!))
            {
                if (lastMatch != null)
                {
                    var d = c.AbsDistance - lastMatch.X;

                    if (d>distance)
                        distance = d;
                }

                lastMatch = c;
            }
            
            if (distance <= maxDistanceBetweenMatches)
                break;
            
        } while (tolerance <= 60);

        sw.Stop();


        var m = matches.GroupBy(i => i.X).Select(i => i.MinBy(i => i.AbsDistance)!).OrderBy(i => i.X).ToArray();

        return m.ToArray();
    }


    private static void  FindWithTolerance(IEnumerable<Pixel> pixels, IEnumerable<Colour> paintColours, ConcurrentBag<Match> matches, int tolerance)
    {
        Parallel.ForEach(pixels, obj =>
        {

            var currentMatch = matches.FirstOrDefault(i => i.X == obj.X);

            if (currentMatch != null)
                return;

            foreach (var item in paintColours)
            {
                var distance = GetDistance(obj.Colour, item.Color);

                var absDistance = Math.Abs(distance);


                if(currentMatch!=null && currentMatch.AbsDistance <= absDistance)
                    continue;

                if(absDistance > tolerance)
                    continue;

                var match = new Match()
                {
                    PaintColour = item,
                    Pixel = obj.Colour,
                    X = obj.X,
                    Distance = distance
                };
                
                matches.Add(match);
                
                currentMatch = match;
            }
        });
    }


    private record Pixel(int X, Color Colour);

    static int GetDistance(Color current, Color match)
    {
        var redDifference = current.R - match.R;
        var greenDifference = current.G - match.G;
        var blueDifference = current.B - match.B;

        return (redDifference * redDifference) +
               (greenDifference * greenDifference) +
               (blueDifference * blueDifference)
            ;
    }

    public class Colour
    {

        public Guid Id { get; set; }
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }



        public string Name { get; set; }
        public string Code { get; set; }


        public ColourSource ColourSource { get; set; }


        private Color? _color;
        [JsonIgnore]
        public Color Color => _color ??= Color.FromArgb(Red, Green, Blue);
    }

    public class Match
    {
        public int X { get; set; }
        public Colour PaintColour { get; set; }
        public Color Pixel { get; set; }



        public int Distance { get; set; }
        public int AbsDistance => Math.Abs(Distance);
    }

    public class MinimalMatch
    {
        public Guid ColourId { get; set; }
        public int X { get; set; }
        public int Distance { get; set; }
    }

    public class Store
    {
        public IDictionary<string, IEnumerable<MinimalMatch>> Matches { get; set; }

        public IEnumerable<Colour> Colours { get; set; }
    }

    public enum ColourSource
    {
        Valspar,
        Pantone
    }

}
