using Graphs;

namespace DsaUnitTests.Graphs;

public class YoungestCommonAncestorTests
{
    public Dictionary<char, YoungestCommonAncestor.Program.AncestralTree> getNewTrees()
    {
        var trees = new Dictionary<char, YoungestCommonAncestor.Program.AncestralTree>();
        var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        foreach (char a in alphabet)
        {
            trees.Add(a, new YoungestCommonAncestor.Program.AncestralTree(a));
        }
        return trees;
    }

    [Fact]
    public void TestCase1()
    {
        var trees = getNewTrees();
        trees['A'].AddAsAncestor(
          new YoungestCommonAncestor.Program.AncestralTree[] { trees['B'], trees['C'] }
        );
        trees['B'].AddAsAncestor(
          new YoungestCommonAncestor.Program.AncestralTree[] { trees['D'], trees['E'] }
        );
        trees['D'].AddAsAncestor(
          new YoungestCommonAncestor.Program.AncestralTree[] { trees['H'], trees['I'] }
        );
        trees['C'].AddAsAncestor(
          new YoungestCommonAncestor.Program.AncestralTree[] { trees['F'], trees['G'] }
        );

        YoungestCommonAncestor.Program.AncestralTree yca =
          YoungestCommonAncestor.Program.GetYoungestCommonAncestor(trees['A'], trees['E'], trees['I']);
    }
}
