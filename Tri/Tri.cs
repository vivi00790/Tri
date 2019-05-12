using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri
{
    public class Tri
    {
        public string getType(int edge1, int edge2, int edge3)
        {
            if (edge1 == edge2 && edge2 == edge3)
            {
                return "regular triangle";
            }
            return "not triangle";
        }
    }
}
