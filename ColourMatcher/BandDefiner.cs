using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ColourMatcher.Site.Code;

namespace ColourMatcher;

internal class BandDefiner
{
    public static async Task GetBands()
    {

        var files = Directory.GetFiles("C:\\Source\\Prototyping\\ColourMatcher\\ColourMatcher\\Bands");

        var results = new ConcurrentDictionary<string, IEnumerable<Boundary>>();

        foreach (var s in files)
        {


            var image = Image.FromFile(s);
            var bitmap = new Bitmap(image);
            var f = Path.GetFileNameWithoutExtension(s);
            var boundaries = Boundaries.GetFor(f);

            var pixelsArray = Enumerable.Range(0, image.Width - 1).Select(i => new { X = i, P = bitmap.GetPixel(i, 0) }).ToArray();

            var bItems = new List<Boundary>();

            foreach (var (index, boundary) in boundaries.Index())
            {
                if (string.IsNullOrWhiteSpace(boundary.Hex))
                {
                    bItems.Add(new Boundary(boundary.Text,null, 0, 0));
                    continue;
                }

                if (index == boundaries.Count() - 1)
                {
                    bItems.Add(new Boundary(boundary.Text, boundary.Hex, image.Width, 1));
                    continue;
                }


                var color = ColorTranslator.FromHtml("#" + boundary.Hex);

                var rightMost2 = pixelsArray
                    .Where(i => Math.Abs(Helpers.GetDistance(color, i.P)) <= 100)
                    .Select(i => new
                    {
                        Weight = Math.Abs(Helpers.GetDistance(color, i.P)),
                        i.X,
                        i.P
                    })
                    .ToArray();

                var rightMost = rightMost2
                    .OrderBy(i => i.Weight)
                    .ThenByDescending(i => i.X)
                    .FirstOrDefault();

                var perCent = rightMost.X / ((decimal)image.Width);

                var b = new Boundary(boundary.Text, boundary.Hex, rightMost.X, perCent)
                {
                    Invert = boundary.Invert
                };
                bItems.Add(b);
            }

            results.TryAdd(f, bItems);
        }

        var code = new List<string>();

        foreach (var item in results.OrderBy(i=>i.Key))
        {

            var filename =
                Boundaries.Filenames.First(i => i.Equals(item.Key, StringComparison.InvariantCultureIgnoreCase));

            var lines = item.Value.Select(i =>
                $"new Boundary({(i.Text == null ? "null" : $"\"{i.Text}\"")}, {(i.Hex == null ? "null" : $"\"{i.Hex}\"")}, {i.X}, {i.Percentage}m)" +
                (i.Invert ? "{ Invert = true }" : "") + ",");

            var line = $"private static readonly IEnumerable<Boundary> {filename} = {Environment.NewLine}[" +
                       string.Join(Environment.NewLine, lines) + Environment.NewLine + "];";
            code.Add(line);
        }

        var str = string.Join(Environment.NewLine, code);


        var resultPath = "C:\\Source\\Prototyping\\ColourMatcher\\ColourMatcher\\boundaries.json";

        if (File.Exists(resultPath))
            File.Delete(resultPath);

        await File.WriteAllTextAsync(resultPath, JsonSerializer.Serialize(results));
    }


}
