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

        //int StepSize { get { return 1; } }
        protected virtual int StepSize { get; } = 1;

        // Arrow function
        public MapLocation Location => _path.GetLocationAt(_pathStep);

        // Set initial value
        //public int Health { get; private set; } = 2;
        // Virtualize with "virtual" modifier, must change access modifier to protected
        public virtual int Health { get; protected set; } = 2;

        // True if invader has reached end of path
        public bool HasScored { get { return _pathStep >= _path.Length; } }

        // Make comparisons as general as possible:
        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        // Constructor
        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += StepSize;
        //public virtual void Move() => _pathStep += 1;

        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
            Console.WriteLine("Shot at and hit an invader!");
        }
    }
}
