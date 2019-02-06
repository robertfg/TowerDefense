using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Point1
    {
        // Properties
        public readonly int X;
        public readonly int Y;

        // Constructor
        public Point1(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Override ToString() method:
        public override string ToString()
        {
            return X + ", " + Y;
        }

        // Override Equals:
        public override bool Equals(object obj)
        {
            if ( !(obj is Point) )
            {
                return false;
            }

            Point that = obj as Point;

            return this.X == that.X  &&  this.Y == that.Y;
        }

        // Override GetHashCode:
        public override int GetHashCode()
        {
            /* Generated automatically by VS:
            var hashCode = 1861411795;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            return hashCode;*/

            // Use a small prime number to get the hashcode:
            // return X * 31 + Y;

            // Better:
            return X.GetHashCode() * 31 + Y.GetHashCode();
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
