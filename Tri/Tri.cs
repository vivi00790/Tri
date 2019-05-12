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
            int[] edges = {edge1, edge2, edge3};
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
                return $"{TriangleTypePrefix.Not.ToString().ToLower()} {result}";
            }

            if (longestEdge == secondLongestEdge)
            {
                result = secondLongestEdge == shortestEdge ? $"{TriangleTypePrefix.Regular.ToString().ToLower()} {result}" : $"{TriangleTypePrefix.Isosceles.ToString().ToLower()} {result}";
            }

            if (longestEdgeSquare > secondLongestEdgeSquare + shortestEdgeSquare)
            {
                result = $"{TriangleTypePrefix.Obtuse.ToString().ToLower()} {result}";
            }



            return result;
        }

        private enum TriangleTypePrefix
        {
            Not,
            Regular,
            Isosceles,
            Obtuse
        }
    }
}
