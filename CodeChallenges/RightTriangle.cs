using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    class RightTriangle
    {
        public static double CalculateHypotenuse(double leg1, double leg2)
        {
            return System.Math.Sqrt((leg1 * leg1) + (leg2 * leg2));
        }
    }
}
