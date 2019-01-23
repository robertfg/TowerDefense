using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Map
    {
        // Attributes: instance-level variables
        public readonly int Width;
        public readonly int Height;

        // Constructor method: method-level variables
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        // Methods
        public bool OnMap(Point point)
        {
            //bool inBounds    = point.X >= 0  &&  point.X < Width   &&  point.Y >= 0  &&  point.Y < Height;
            //bool outOfBounds = point.X < 0   ||  point.X >= Width  ||  point.Y < 0   ||  point.Y >= Height;
            //inBounds = !outOfBounds;
            //return inBounds;

            return  point.X >= 0 && point.X < Width &&
                    point.Y >= 0 && point.Y < Height;
        }
    }
}
