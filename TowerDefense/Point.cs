﻿using System;
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
            return X.GetHashCode() * 31 + Y.GetHashCode();
        }

        // Methods
        public int DistanceTo(int x, int y)
        {
            return (int)Math.Sqrt(Math.Pow(X-x, 2) + Math.Pow(Y-y, 2));
        }

        // Overload DistanceTo method:
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}
