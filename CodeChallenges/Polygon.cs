using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    class Polygon
    {
        public readonly int NumSides;

        public Polygon(int numSides)
        {
            NumSides = numSides;
        }
    }

    class Square : Polygon
    {
        //public readonly int SideLength;
        public int SideLength;

        // Arrow function
        public double Area => SideLength * SideLength;

        // Computed field
        /*public double Area
        {
            get
            {
                return SideLength * SideLength;
            }
        }*/

        public Square(int sideLength) : base(4)
        {
            SideLength = sideLength;
        }

        // VS doesn't like this for methods:
        //public void Scale(double factor) => SideLength *= factor;

        public void Scale(double factor)
        {
            //SideLength *= factor;
            SideLength *= (int)factor;
        }
    }
}
