using System.Drawing;

namespace ColourMatcher.Site.Code;

public class Boundaries
{
    public static readonly IEnumerable<string> Filenames =
    [
        nameof(Madder1), nameof(Madder2), nameof(Madder3), nameof(MadderPurple), nameof(Morello), nameof(Cochineal),
        nameof(Kermes), nameof(Bedstraw), nameof(Sappanwood1), nameof(Sappanwood2), nameof(Saffron), nameof(Weld1),
        nameof(Weld2), nameof(Weld3), nameof(WeldWood), nameof(Coppersalt), nameof(Orchil), nameof(Murex1),
        nameof(Murex2),
        nameof(Tannins1), nameof(Wood), nameof(Indigo)
    ];


    private static readonly IEnumerable<Boundary> Bedstraw =
    [
        new(null, null, 0, 0m),
        new("1", "ffc433", 98, 0.1734513274336283185840707965m),
        new("2", "ff9927", 176, 0.3115044247787610619469026549m),
        new("3", "fc5420", 287, 0.5079646017699115044247787611m),
        new("4", "dc0502", 565, 1m)
    ];

    private static readonly IEnumerable<Boundary> Cochineal =
    [
        new("<4", null, 0, 0m),
        new("4", "ffa3e0", 105, 0.1842105263157894736842105263m),
        new("5", "ff5fd9", 184, 0.3228070175438596491228070175m),
        new("6", "ff05ad", 313, 0.549122807017543859649122807m),
        new("7", "bd045a", 451, 0.7912280701754385964912280702m),
        new("8", "781429", 570, 1m)
    ];

    private static readonly IEnumerable<Boundary> Coppersalt =
    [
        new("<7", null, 0, 0m),
        new("7", "36ff8b", 199, 0.3436960276338514680483592401m),
        new("8", "05a360", 362, 0.6252158894645941278065630397m),
        new("9", "162f2e", 579, 1m)
    ];

    private static readonly IEnumerable<Boundary> Indigo =
    [
        new("<5", null, 0, 0m),
        new("5", "48b7ff", 206, 0.3545611015490533562822719449m),
        new("6", "1168cb", 419, 0.7211703958691910499139414802m),
        new("7", "1b235f", 581, 1m)
    ];

    private static readonly IEnumerable<Boundary> Kermes =
    [
        new("<6", null, 0, 0m),
        new("6", "ff0707", 201, 0.3513986013986013986013986014m),
        new("7", "ce0613", 394, 0.6888111888111888111888111888m),
        new("8", "a70828", 572, 1m)
    ];

    private static readonly IEnumerable<Boundary> Madder1 =
    [
        new("1", "ffae90", 102, 0.1808510638297872340425531915m),
        new("2", "ff8969", 160, 0.2836879432624113475177304965m),
        new("3", "ff6c4b", 203, 0.3599290780141843971631205674m),
        new("4", "ff1210", 327, 0.5797872340425531914893617021m),
        new("5", "c52006", 564, 1m)
    ];

    private static readonly IEnumerable<Boundary> Madder2 =
    [
        new("1", "f9c2b3", 124, 0.2206405693950177935943060498m),
        new("2", "f7afa6", 161, 0.286476868327402135231316726m),
        new("3", "ef9492", 207, 0.3683274021352313167259786477m),
        new("4", "d15252", 365, 0.6494661921708185053380782918m),
        new("5", "ab0909", 562, 1m)
    ];

    private static readonly IEnumerable<Boundary> Madder3 =
    [
        new("1", "ff8b57", 184, 0.3245149911816578483245149912m),
        new("2", "ff6e32", 225, 0.3968253968253968253968253968m),
        new("3", "f53e03", 327, 0.5767195767195767195767195767m),
        new("4", "7d270c", 567, 1m)
    ];

    private static readonly IEnumerable<Boundary> MadderPurple =
    [
        new("<4", null, 0, 0m),
        new("4", "c6bdd3", 114, 0.2m),
        new("5", "978da3", 288, 0.5052631578947368421052631579m),
        new("6", "7e7489", 402, 0.7052631578947368421052631579m),
        new("7", "625466", 570, 1m)
    ];

    private static readonly IEnumerable<Boundary> Morello =
    [
        new("<4", null, 0, 0m),
        new("5", "341311", 291, 0.5034602076124567474048442907m),
        new("6", "030101", 578, 1m)
    ];

    private static readonly IEnumerable<Boundary> Murex1 =
    [
        new("<7", null, 0, 0m),
        new("7", "d2a8ff", 104, 0.1786941580756013745704467354m),
        new("8", "833cef", 316, 0.5429553264604810996563573883m),
        new("9", "201957", 582, 1m)
    ];

    private static readonly IEnumerable<Boundary> Murex2 =
    [
        new("<7", null, 0, 0m),
        new("7", "e363ff", 184, 0.3188908145580589254766031196m),
        new("8", "6e04a9", 492, 0.8526863084922010398613518198m),
        new("9", "3b0f84", 577, 1m)
    ];

    private static readonly IEnumerable<Boundary> Orchil =
    [
        new("<6", null, 0, 0m),
        new("6 (trim)", "f256ac", 238, 0.4096385542168674698795180723m),
        new("7", "a71ba1", 415, 0.7142857142857142857142857143m),
        new("8", "4d1384", 581, 1m)
    ];

    private static readonly IEnumerable<Boundary> Saffron =
    [
        new("<8", null, 0, 0m),
        new("8", "ff9905", 284, 0.4965034965034965034965034965m),
        new("9", "ff3204", 572, 1m)
    ];

    private static readonly IEnumerable<Boundary> Sappanwood1 =
    [
        new("<5", null, 0, 0m),
        new("5", "ff3833", 278, 0.4885764499121265377855887522m),
        new("6", "f3211d", 425, 0.7469244288224956063268892794m),
        new("7", "d61110", 569, 1m)
    ];

    private static readonly IEnumerable<Boundary> Sappanwood2 =
    [
        new("<5", null, 0, 0m),
        new("5", "f05968", 145, 0.2598566308243727598566308244m),
        new("6", "b64451", 321, 0.5752688172043010752688172043m),
        new("7", "d61110", 558, 1m)
    ];

    private static readonly IEnumerable<Boundary> Tannins1 =
    [
        new(null, null, 0, 0m),
        new("1", "ded7c7", 84, 0.1492007104795737122557726465m),
        new("2", "cbc7b9", 150, 0.2664298401420959147424511545m),
        new("3", "aba99c", 216, 0.3836589698046181172291296625m),
        new("4", "908e81", 272, 0.4831261101243339253996447602m),
        new("5", "76736c", 326, 0.5790408525754884547069271758m),
        new("6", "605f59", 367, 0.6518650088809946714031971581m),
        new("7", "4a4945", 417, 0.7406749555950266429840142096m) { Invert = true },
        new("8", "393834", 468, 0.8312611012433392539964476021m) { Invert = true },
        new("9", "060606", 563, 1m)
    ];

    private static readonly IEnumerable<Boundary> Weld1 =
    [
        new(null, null, 0, 0m),
        new("1", "faf446", 182, 0.3209876543209876543209876543m),
        new("2", "fdf425", 224, 0.3950617283950617283950617284m),
        new("3", "f7ee11", 337, 0.594356261022927689594356261m),
        new("4", "746403", 567, 1m)
    ];

    private static readonly IEnumerable<Boundary> Weld2 =
    [
        new(null, null, 0, 0m),
        new("1", "d1bf3d", 298, 0.5218914185639229422066549912m),
        new("2", "b5a938", 381, 0.6672504378283712784588441331m),
        new("3", "737831", 571, 1m)
    ];

    private static readonly IEnumerable<Boundary> Weld3 =
    [
        new("<2", null, 0, 0m),
        new("2", "e1ee58", 182, 0.3170731707317073170731707317m),
        new("3", "c4ca21", 358, 0.6236933797909407665505226481m),
        new("4", "98b504", 574, 1m)
    ];

    private static readonly IEnumerable<Boundary> WeldWood =
    [
        new("<2", null, 0, 0m),
        new("2", "bbfc51", 103, 0.179130434782608695652173913m),
        new("3", "83e46c", 273, 0.4747826086956521739130434783m),
        new("4", "52c684", 433, 0.7530434782608695652173913043m),
        new("5", "58ac9e", 575, 1m)
    ];

    private static readonly IEnumerable<Boundary> Wood =
    [
        new(null, null, 0, 0m),
        new("1", "cad9ef", 17, 0.0298769771528998242530755712m),
        new("2", "b6cef4", 84, 0.147627416520210896309314587m),
        new("3", "83aeee", 170, 0.2987697715289982425307557118m),
        new("4", "4689e2", 282, 0.4956063268892794376098418278m),
        new("5", "2565b4", 427, 0.7504393673110720562390158172m),
        new("6", "16305d", 569, 1m)
    ];

    public static IEnumerable<Boundary> GetFor(string filename)
    {
        if (filename.Equals(nameof(Madder1), StringComparison.CurrentCultureIgnoreCase)) return Madder1;

        if (filename.Equals(nameof(Madder2), StringComparison.CurrentCultureIgnoreCase)) return Madder2;

        if (filename.Equals(nameof(Madder3), StringComparison.CurrentCultureIgnoreCase)) return Madder3;

        if (filename.Equals(nameof(MadderPurple), StringComparison.CurrentCultureIgnoreCase)) return MadderPurple;

        if (filename.Equals(nameof(Morello), StringComparison.CurrentCultureIgnoreCase)) return Morello;

        if (filename.Equals(nameof(Cochineal), StringComparison.CurrentCultureIgnoreCase)) return Cochineal;

        if (filename.Equals(nameof(Kermes), StringComparison.CurrentCultureIgnoreCase)) return Kermes;

        if (filename.Equals(nameof(Bedstraw), StringComparison.CurrentCultureIgnoreCase)) return Bedstraw;

        if (filename.Equals(nameof(Sappanwood1), StringComparison.CurrentCultureIgnoreCase)) return Sappanwood1;

        if (filename.Equals(nameof(Sappanwood2), StringComparison.CurrentCultureIgnoreCase)) return Sappanwood2;

        if (filename.Equals(nameof(Saffron), StringComparison.CurrentCultureIgnoreCase)) return Saffron;

        if (filename.Equals(nameof(Weld1), StringComparison.CurrentCultureIgnoreCase)) return Weld1;

        if (filename.Equals(nameof(Weld2), StringComparison.CurrentCultureIgnoreCase)) return Weld2;

        if (filename.Equals(nameof(Weld3), StringComparison.CurrentCultureIgnoreCase)) return Weld3;

        if (filename.Equals(nameof(WeldWood), StringComparison.CurrentCultureIgnoreCase)) return WeldWood;

        if (filename.Equals(nameof(Coppersalt), StringComparison.CurrentCultureIgnoreCase)) return Coppersalt;

        if (filename.Equals(nameof(Orchil), StringComparison.CurrentCultureIgnoreCase)) return Orchil;

        if (filename.Equals(nameof(Murex1), StringComparison.CurrentCultureIgnoreCase)) return Murex1;

        if (filename.Equals(nameof(Tannins1), StringComparison.CurrentCultureIgnoreCase)) return Tannins1;

        if (filename.Equals(nameof(Wood), StringComparison.CurrentCultureIgnoreCase)) return Wood;

        if (filename.Equals(nameof(Indigo), StringComparison.CurrentCultureIgnoreCase)) return Indigo;

        if (filename.Equals(nameof(Murex2), StringComparison.CurrentCultureIgnoreCase)) return Murex2;

        return Array.Empty<Boundary>();

        //var props = typeof(BandBreakdown).GetFields(BindingFlags.Static | BindingFlags.NonPublic);


        //var str = new List<string>();
        //var str2 = new List<string>();
        //foreach (var prop in props)
        //{
        //    if (filename.Equals(nameof(Madder1), StringComparison.CurrentCultureIgnoreCase)) return Madder1;


        //    var s =
        //        $"if (filename.Equals(nameof({prop.Name}), StringComparison.CurrentCultureIgnoreCase)) return {prop.Name};"+Environment.NewLine;

        //    str.Add(s);

        //    str2.Add($"nameof({prop.Name})");
        //}

        //var code = string.Join(Environment.NewLine, str);
        //var c2 = string.Join(", ", str2);
    }
}

public record Boundary(string? Text, string? Hex, int X, decimal Percentage)
{
    public bool Invert { get; init; }
}

public class Matches
{
   
}

public enum ColourSource
{
    Valspar = 0,
    Pantone = 1,
}

public record PairedColour(int X, int Distance, decimal Percentage, MatchedColour Colour)
{
    public int AbsDistance => Math.Abs(Distance);
}


public record MatchedColour(Guid Id, Color Colour, string Code, string Name, ColourSource Source);
