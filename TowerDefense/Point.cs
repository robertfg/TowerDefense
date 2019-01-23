using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Point
    {
        // Properties
        public readonly int X;
        public readonly int Y;

        // Constructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Methods
        public int DistanceTo(int x, int y)
        {
            /*int xDiff = X - x;
            int yDiff = Y - y;

            int xDiffSquared = xDiff * xDiff;
            int yDiffSquared = yDiff * yDiff;

            return (int)Math.Sqrt(xDiffSquared + yDiffSquared);*/

            // After you refactor:
            return (int)Math.Sqrt(Math.Pow(X-x, 2) + Math.Pow(Y-y, 2));
        }

        // Overload DistanceTo method:
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}
