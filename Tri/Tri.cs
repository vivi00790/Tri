using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri
{
    public class Tri
    {
        public string GetType(int edge1, int edge2, int edge3)
        {
            long[] edges = {edge1, edge2, edge3};
            Array.Sort(edges);
            var result = "triangle";
            
            var longestEdge = edges[2];
            var secondLongestEdge = edges[1];
            var shortestEdge = edges[0];
            var longestEdgeSquare = edges[2]* edges[2];
            var secondLongestEdgeSquare = edges[1] * edges[1];
            var shortestEdgeSquare = edges[0] * edges[0];

            if (longestEdge >= secondLongestEdge + shortestEdge)
            {
                return AddPrefix(TriangleTypePrefix.Not, result);
            }

            if (AllEdgesAreEqual(edges))
            {
                return AddPrefix(TriangleTypePrefix.Regular, result);
            }

            if (OnlyTwoEdgesAreEqual(edges))
            {
                result = AddPrefix(TriangleTypePrefix.Isosceles, result);
            }

            if (longestEdgeSquare > secondLongestEdgeSquare + shortestEdgeSquare)
            {
                result = AddPrefix(TriangleTypePrefix.Obtuse, result);
            }

            if (longestEdgeSquare < secondLongestEdgeSquare + shortestEdgeSquare)
            {
                result = AddPrefix(TriangleTypePrefix.Acute, result);
            }

            if (longestEdgeSquare == secondLongestEdgeSquare + shortestEdgeSquare)
            {
                result = AddPrefix(TriangleTypePrefix.Right, result);
            }

            return result;
        }

        private static bool OnlyTwoEdgesAreEqual(long[] edges)
        {
            return edges.GroupBy(x => x).Count() == 2;
        }

        private static bool AllEdgesAreEqual(long[] edges)
        {
            return edges.GroupBy(x => x).Count() == 1;
        }

        private static string AddPrefix(TriangleTypePrefix triangleTypePrefix, string originalString)
        {
            return $"{triangleTypePrefix.ToString().ToLower()} {originalString}";
        }

        private enum TriangleTypePrefix
        {
            Not,
            Regular,
            Isosceles,
            Obtuse,
            Acute,
            Right
        }
    }
}
