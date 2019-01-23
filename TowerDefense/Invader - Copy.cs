using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Invader1
    {
        private MapLocation _location;

        /*public MapLocation GetLocation()
        {
            return _location;
        }

        public void SetLocation(MapLocation location)
        {
            _location = location;
        }*/

        // Same as above:
        public MapLocation Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }
    }
}
