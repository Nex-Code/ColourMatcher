using System.Collections.Concurrent;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text.Json;
using System.Text.Json.Serialization;
using ColourMatcher;
using static ColourMatcher.ColourFinder;




var items = JsonSerializer.Deserialize<IEnumerable<valspar>>(await File.ReadAllTextAsync("C:\\Source\\Prototyping\\ColourMatcher\\ColourMatcher\\rawValspar.json"))!.ToFrozenSet();

var valspar = items.DistinctBy(i => i.code).ToDictionary(i=>i.code, i=>i.url);

var json = JsonSerializer.Serialize(valspar);







Console.ReadLine();

public static class Helpers
{
    public static int GetDistance(Color current, Color match)
    {
        var redDifference = current.R - match.R;
        var greenDifference = current.G - match.G;
        var blueDifference = current.B - match.B;

        return (redDifference * redDifference) +
               (greenDifference * greenDifference) +
               (blueDifference * blueDifference)
            ;
    }
}






public class valspar
{
    public string rgb { get; set; }
    public string name { get; set; }
    public string code { get; set; }
    public string url { get; set; }
}