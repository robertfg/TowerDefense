using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class MapLocation : Point
    {
        //public MapLocation(int x, int y) : base(x, y)
        public MapLocation(int x, int y, Map map) : base (x, y)
        {
            // Validate whether or not point is on map
            if(!map.OnMap(this))
            {
                //throw new Exception();
                //throw new Exception(x + "," + y + " is outside the boundaries of the map.");
                throw new OutOfBoundsException(x + "," + y + " is outside the boundaries of the map.");
            }
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}
