using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class StrongInvader : Invader
    {
        // Access modifier must also be protected, like parent class
        public override int Health { get; protected set; } = 2;

        public StrongInvader(Path path)
            : base(path)
        {

        }
    }
}
