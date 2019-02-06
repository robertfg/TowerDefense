using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class SuperTower : Tower
    {
        protected override int Range { get; } = 3;
        protected override int Power { get; } = 3;
        protected override double Accuracy { get; } = 1.5;

        public SuperTower(MapLocation location)
            : base(location)
        {

        }
    }
}
