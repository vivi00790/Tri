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
            var longestEdge = edges[2];
            var secondLongestEdge = edges[1];
            var shortestEdge = edges[0];
            var longestEdgeSquare = edges[2]* edges[2];
            var secondLongestEdgeSquare = edges[1] * edges[1];
            var shortestEdgeSquare = edges[0] * edges[0];

            if (longestEdge >= secondLongestEdge + shortestEdge)
            {
                return "not triangle";
            }

            if (longestEdge == secondLongestEdge)
            {
                return secondLongestEdge == shortestEdge ? "regular triangle" : "isosceles triangle";
            }

            if (longestEdgeSquare > secondLongestEdgeSquare + shortestEdgeSquare)
            {
                return "obtuse triangle";
            }



            return "not triangle";
        }
    }
}
