
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ColourMatcher.Site.Code;

public partial class PairedColours
{

    public static IEnumerable<string> Filenames => Boundaries.Filenames;

    public static IEnumerable<PairedColour> GetFor(string filename)
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

if (filename.Equals(nameof(Murex2), StringComparison.CurrentCultureIgnoreCase)) return Murex2;

if (filename.Equals(nameof(Tannins1), StringComparison.CurrentCultureIgnoreCase)) return Tannins1;

if (filename.Equals(nameof(Wood), StringComparison.CurrentCultureIgnoreCase)) return Wood;

if (filename.Equals(nameof(Indigo), StringComparison.CurrentCultureIgnoreCase)) return Indigo;

        return Array.Empty<PairedColour>();
    }

}