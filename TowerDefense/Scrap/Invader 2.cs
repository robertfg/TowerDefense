using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Invader2
    {
        private readonly Path _path;
        private int _pathStep = 0;

        //public MapLocation Location { get; set; }
        public MapLocation Location { get; private set; }

        // Constructor
        public Invader2(Path path)
        {
            _path = path;
            Location = _path.GetLocationAt(_pathStep);
        }

        public void Move()
        {
            _pathStep += 1;
            Location = _path.GetLocationAt(_pathStep);
        }
    }
}
