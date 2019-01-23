using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        // Arrow function
        public MapLocation Location => _path.GetLocationAt(_pathStep);

        // Set initial value:
        public int Health { get; private set; } = 2;

        // True if invader has reached end of path
        //public bool HasScored => _pathStep >= _path.Length;
        public bool HasScored { get { return _pathStep >= _path.Length; } }

        // Make comparisons as general as possible:
        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        // Computed property
        /*public MapLocation Location
        {
            get
            {
                return _path.GetLocationAt(_pathStep);
            }
        }*/

        // Constructor
        public Invader(Path path)
        {
            _path = path;
            //Health = 2;
        }

        public void Move() => _pathStep += 1;
        /*public void Move()
        {
            _pathStep += 1;
        }*/

        public void DecreaseHealth(int factor)
        {
            Health -= factor;
        }
    }
}
