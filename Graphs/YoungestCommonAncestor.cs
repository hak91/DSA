namespace Graphs;
public class YoungestCommonAncestor
{
    public class Program
    {
        public static AncestralTree GetYoungestCommonAncestor(
          AncestralTree topAncestor,
          AncestralTree descendantOne,
          AncestralTree descendantTwo
        )
        {
            var ancestorOne = descendantOne;
            var depthOne = 0;
            while (ancestorOne is not null)
            {
                depthOne++;
                ancestorOne = ancestorOne.ancestor;
            }

            var ancestorTwo = descendantTwo;
            var depthTwo = 0;
            while (ancestorTwo is not null)
            {
                depthTwo++;
                ancestorTwo = ancestorTwo.ancestor;
            }

            var diff = 0;
            var minDepth = 0;
            AncestralTree lowerDescendent;
            AncestralTree upperDescendant;
            if (depthTwo > depthOne)
            {
                diff = depthTwo - depthOne;
                minDepth = depthOne;
                lowerDescendent = descendantTwo;
                upperDescendant = descendantOne;
            }
            else
            {
                diff = depthOne - depthTwo;
                minDepth = depthTwo;
                lowerDescendent = descendantOne;
                upperDescendant = descendantTwo;
            }
            AncestralTree sameLevelDescendent = lowerDescendent;
            for (var i = 0; i < diff; i++)
            {
                sameLevelDescendent = sameLevelDescendent.ancestor!;
            }

            while (sameLevelDescendent != upperDescendant)
            {
                sameLevelDescendent = sameLevelDescendent.ancestor;
                upperDescendant = upperDescendant.ancestor;
            }

            return sameLevelDescendent;
        }

        public class AncestralTree
        {
            public char name;
            public AncestralTree? ancestor;

            public AncestralTree(char name)
            {
                this.name = name;
                this.ancestor = null;
            }

            // This method is for testing only.
            public void AddAsAncestor(AncestralTree[] descendants)
            {
                foreach (AncestralTree descendant in descendants)
                {
                    descendant.ancestor = this;
                }
            }
        }
    }
}

