
using System;
using System.Collections.Generic;

namespace ColourMatcher.Site.Code;

public partial class PairedColours
{
    private static readonly IEnumerable<PairedColour> Wood = [
new PairedColour(0,14, 0m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(1,14, 0.0017574692442882249560632689m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(2,14, 0.0035149384885764499121265378m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(3,14, 0.0052724077328646748681898067m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(4,14, 0.0070298769771528998242530756m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(5,14, 0.0087873462214411247803163445m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(6,14, 0.0105448154657293497363796134m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(7,14, 0.0123022847100175746924428822m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(8,14, 0.0140597539543057996485061511m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(9,14, 0.01581722319859402460456942m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(10,14, 0.0175746924428822495606326889m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(11,14, 0.0193321616871704745166959578m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(12,14, 0.0210896309314586994727592267m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(13,14, 0.0228471001757469244288224956m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(14,14, 0.0246045694200351493848857645m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(15,14, 0.0263620386643233743409490334m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(16,14, 0.0281195079086115992970123023m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(17,14, 0.0298769771528998242530755712m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(18,18, 0.0316344463971880492091388401m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(19,18, 0.033391915641476274165202109m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(20,18, 0.0351493848857644991212653779m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(21,18, 0.0369068541300527240773286467m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(22,17, 0.0386643233743409490333919156m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(23,17, 0.0404217926186291739894551845m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(24,17, 0.0421792618629173989455184534m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(25,14, 0.0439367311072056239015817223m, MatchedColours.Lookup(Guid.Parse("3d850df8-c872-4805-9e7e-a18c78b8c5e7"))),
new PairedColour(26,9, 0.0456942003514938488576449912m, MatchedColours.Lookup(Guid.Parse("3d850df8-c872-4805-9e7e-a18c78b8c5e7"))),
new PairedColour(27,9, 0.0474516695957820738137082601m, MatchedColours.Lookup(Guid.Parse("3d850df8-c872-4805-9e7e-a18c78b8c5e7"))),
new PairedColour(28,9, 0.049209138840070298769771529m, MatchedColours.Lookup(Guid.Parse("3d850df8-c872-4805-9e7e-a18c78b8c5e7"))),
new PairedColour(29,17, 0.0509666080843585237258347979m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(30,25, 0.0527240773286467486818980668m, MatchedColours.Lookup(Guid.Parse("3d850df8-c872-4805-9e7e-a18c78b8c5e7"))),
new PairedColour(31,25, 0.0544815465729349736379613357m, MatchedColours.Lookup(Guid.Parse("3d850df8-c872-4805-9e7e-a18c78b8c5e7"))),
new PairedColour(32,18, 0.0562390158172231985940246046m, MatchedColours.Lookup(Guid.Parse("3d850df8-c872-4805-9e7e-a18c78b8c5e7"))),
new PairedColour(33,21, 0.0579964850615114235500878735m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(34,21, 0.0597539543057996485061511424m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(35,21, 0.0615114235500878734622144112m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(36,26, 0.0632688927943760984182776801m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(37,26, 0.065026362038664323374340949m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(38,26, 0.0667838312829525483304042179m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(39,26, 0.0685413005272407732864674868m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(40,26, 0.0702987697715289982425307557m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(41,26, 0.0720562390158172231985940246m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(42,26, 0.0738137082601054481546572935m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(43,36, 0.0755711775043936731107205624m, MatchedColours.Lookup(Guid.Parse("89f1e4e7-c659-41ba-8cde-8318207aa9a0"))),
new PairedColour(44,57, 0.0773286467486818980667838313m, MatchedColours.Lookup(Guid.Parse("3d850df8-c872-4805-9e7e-a18c78b8c5e7"))),
new PairedColour(45,57, 0.0790861159929701230228471002m, MatchedColours.Lookup(Guid.Parse("3d850df8-c872-4805-9e7e-a18c78b8c5e7"))),
new PairedColour(46,57, 0.0808435852372583479789103691m, MatchedColours.Lookup(Guid.Parse("3d850df8-c872-4805-9e7e-a18c78b8c5e7"))),
new PairedColour(47,57, 0.082601054481546572934973638m, MatchedColours.Lookup(Guid.Parse("3d850df8-c872-4805-9e7e-a18c78b8c5e7"))),
];
}