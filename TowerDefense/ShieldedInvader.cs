using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class ShieldedInvader : Invader
    {
        // Create new random variable:
        private static System.Random _random = new System.Random();

        public ShieldedInvader(Path path)
            : base(path)
        {

        }

        public override void DecreaseHealth(int factor)
        {
            if ( _random.NextDouble() < 0.5 )
            {
                base.DecreaseHealth(factor);
            }
            else
            {
                Console.WriteLine("Shot at a Shielded Invader, but it sustained no damage!");
            }
        }

    }
}
