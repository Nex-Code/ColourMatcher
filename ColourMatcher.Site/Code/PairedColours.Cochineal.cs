
using System;
using System.Collections.Generic;

namespace ColourMatcher.Site.Code;

public partial class PairedColours
{
    private static readonly IEnumerable<PairedColour> Cochineal = [
new PairedColour(0,8, 0m, MatchedColours.Lookup(Guid.Parse("457421f0-3338-48f1-ac31-5f9e87b5b739"))),
new PairedColour(1,9, 0.001754385964912280701754386m, MatchedColours.Lookup(Guid.Parse("7053b7f7-e356-485a-bd7b-e89f1d2759a5"))),
new PairedColour(2,9, 0.0035087719298245614035087719m, MatchedColours.Lookup(Guid.Parse("457421f0-3338-48f1-ac31-5f9e87b5b739"))),
new PairedColour(3,9, 0.0052631578947368421052631579m, MatchedColours.Lookup(Guid.Parse("457421f0-3338-48f1-ac31-5f9e87b5b739"))),
new PairedColour(4,17, 0.0070175438596491228070175439m, MatchedColours.Lookup(Guid.Parse("457421f0-3338-48f1-ac31-5f9e87b5b739"))),
new PairedColour(5,17, 0.0087719298245614035087719298m, MatchedColours.Lookup(Guid.Parse("457421f0-3338-48f1-ac31-5f9e87b5b739"))),
new PairedColour(6,18, 0.0105263157894736842105263158m, MatchedColours.Lookup(Guid.Parse("457421f0-3338-48f1-ac31-5f9e87b5b739"))),
new PairedColour(7,17, 0.0122807017543859649122807018m, MatchedColours.Lookup(Guid.Parse("457421f0-3338-48f1-ac31-5f9e87b5b739"))),
new PairedColour(8,20, 0.0140350877192982456140350877m, MatchedColours.Lookup(Guid.Parse("eed8d251-ea17-4921-9e64-2313742159d0"))),
new PairedColour(9,14, 0.0157894736842105263157894737m, MatchedColours.Lookup(Guid.Parse("eed8d251-ea17-4921-9e64-2313742159d0"))),
new PairedColour(10,17, 0.0175438596491228070175438596m, MatchedColours.Lookup(Guid.Parse("eed8d251-ea17-4921-9e64-2313742159d0"))),
new PairedColour(11,17, 0.0192982456140350877192982456m, MatchedColours.Lookup(Guid.Parse("eed8d251-ea17-4921-9e64-2313742159d0"))),
new PairedColour(12,17, 0.0210526315789473684210526316m, MatchedColours.Lookup(Guid.Parse("eed8d251-ea17-4921-9e64-2313742159d0"))),
new PairedColour(13,17, 0.0228070175438596491228070175m, MatchedColours.Lookup(Guid.Parse("eed8d251-ea17-4921-9e64-2313742159d0"))),
new PairedColour(14,14, 0.0245614035087719298245614035m, MatchedColours.Lookup(Guid.Parse("eed8d251-ea17-4921-9e64-2313742159d0"))),
new PairedColour(15,12, 0.0263157894736842105263157895m, MatchedColours.Lookup(Guid.Parse("a8d790fc-f235-4fe1-8a66-2c82315b9bdd"))),
new PairedColour(16,12, 0.0280701754385964912280701754m, MatchedColours.Lookup(Guid.Parse("a8d790fc-f235-4fe1-8a66-2c82315b9bdd"))),
new PairedColour(17,13, 0.0298245614035087719298245614m, MatchedColours.Lookup(Guid.Parse("eed8d251-ea17-4921-9e64-2313742159d0"))),
new PairedColour(18,19, 0.0315789473684210526315789474m, MatchedColours.Lookup(Guid.Parse("7af16159-2e11-4d99-8ca6-3934582cd681"))),
new PairedColour(19,19, 0.0333333333333333333333333333m, MatchedColours.Lookup(Guid.Parse("7af16159-2e11-4d99-8ca6-3934582cd681"))),
new PairedColour(20,17, 0.0350877192982456140350877193m, MatchedColours.Lookup(Guid.Parse("a8d790fc-f235-4fe1-8a66-2c82315b9bdd"))),
new PairedColour(21,17, 0.0368421052631578947368421053m, MatchedColours.Lookup(Guid.Parse("bd3acda4-e92c-46ea-a800-8a0c9a163e0b"))),
new PairedColour(22,14, 0.0385964912280701754385964912m, MatchedColours.Lookup(Guid.Parse("bd3acda4-e92c-46ea-a800-8a0c9a163e0b"))),
new PairedColour(23,9, 0.0403508771929824561403508772m, MatchedColours.Lookup(Guid.Parse("bd3acda4-e92c-46ea-a800-8a0c9a163e0b"))),
new PairedColour(24,9, 0.0421052631578947368421052632m, MatchedColours.Lookup(Guid.Parse("a65f863c-64a2-404c-b5fc-f40966ef87a8"))),
new PairedColour(25,5, 0.0438596491228070175438596491m, MatchedColours.Lookup(Guid.Parse("df43ce93-39e0-49ed-bab5-122f400ed4d6"))),
new PairedColour(26,3, 0.0456140350877192982456140351m, MatchedColours.Lookup(Guid.Parse("df43ce93-39e0-49ed-bab5-122f400ed4d6"))),
new PairedColour(27,2, 0.0473684210526315789473684211m, MatchedColours.Lookup(Guid.Parse("df43ce93-39e0-49ed-bab5-122f400ed4d6"))),
new PairedColour(28,5, 0.049122807017543859649122807m, MatchedColours.Lookup(Guid.Parse("df43ce93-39e0-49ed-bab5-122f400ed4d6"))),
new PairedColour(29,5, 0.050877192982456140350877193m, MatchedColours.Lookup(Guid.Parse("df43ce93-39e0-49ed-bab5-122f400ed4d6"))),
new PairedColour(30,5, 0.0526315789473684210526315789m, MatchedColours.Lookup(Guid.Parse("df43ce93-39e0-49ed-bab5-122f400ed4d6"))),
new PairedColour(31,5, 0.0543859649122807017543859649m, MatchedColours.Lookup(Guid.Parse("df43ce93-39e0-49ed-bab5-122f400ed4d6"))),
new PairedColour(32,11, 0.0561403508771929824561403509m, MatchedColours.Lookup(Guid.Parse("df43ce93-39e0-49ed-bab5-122f400ed4d6"))),
new PairedColour(33,11, 0.0578947368421052631578947368m, MatchedColours.Lookup(Guid.Parse("df43ce93-39e0-49ed-bab5-122f400ed4d6"))),
new PairedColour(34,9, 0.0596491228070175438596491228m, MatchedColours.Lookup(Guid.Parse("df43ce93-39e0-49ed-bab5-122f400ed4d6"))),
new PairedColour(35,9, 0.0614035087719298245614035088m, MatchedColours.Lookup(Guid.Parse("df43ce93-39e0-49ed-bab5-122f400ed4d6"))),
new PairedColour(36,17, 0.0631578947368421052631578947m, MatchedColours.Lookup(Guid.Parse("df43ce93-39e0-49ed-bab5-122f400ed4d6"))),
new PairedColour(37,29, 0.0649122807017543859649122807m, MatchedColours.Lookup(Guid.Parse("df43ce93-39e0-49ed-bab5-122f400ed4d6"))),
new PairedColour(38,29, 0.0666666666666666666666666667m, MatchedColours.Lookup(Guid.Parse("df43ce93-39e0-49ed-bab5-122f400ed4d6"))),
new PairedColour(39,34, 0.0684210526315789473684210526m, MatchedColours.Lookup(Guid.Parse("69f5c416-35c6-443e-a17d-2ec600fa2777"))),
new PairedColour(40,26, 0.0701754385964912280701754386m, MatchedColours.Lookup(Guid.Parse("69f5c416-35c6-443e-a17d-2ec600fa2777"))),
new PairedColour(41,52, 0.0719298245614035087719298246m, MatchedColours.Lookup(Guid.Parse("69f5c416-35c6-443e-a17d-2ec600fa2777"))),
new PairedColour(42,53, 0.0736842105263157894736842105m, MatchedColours.Lookup(Guid.Parse("69f5c416-35c6-443e-a17d-2ec600fa2777"))),
new PairedColour(44,51, 0.0771929824561403508771929825m, MatchedColours.Lookup(Guid.Parse("69f5c416-35c6-443e-a17d-2ec600fa2777"))),
];
}