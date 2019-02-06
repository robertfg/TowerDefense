using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Invader3
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
        public Invader3(Path path)
        {
            _path = path;
            //Health = 2;
        }

        public void Move() => _pathStep += 1;
        /*public void Move()
        {
            _pathStep += 1;
        }*/

        // To make polymorphic, convert to virtual class:
        //public void DecreaseHealth(int factor)
        public virtual void DecreaseHealth(int factor)
        {
            // If you find yourself doing a lot of type checks, you should make the class polymorphic
            //if ( this is ShieldedInvader )
            //{
            //    // Do something here
            //}
            //else
            //{
            //    Health -= factor;
            //}

            Console.WriteLine("Shot at and hit an invader!");

            Health -= factor;
        }
    }
}
