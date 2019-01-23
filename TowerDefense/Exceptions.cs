using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class TowerDefenseException : System.Exception
    {
        // Create exceptions that don't have messages
        public TowerDefenseException()
        {

        }

        public TowerDefenseException(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : TowerDefenseException
    {
        // Create exceptions that don't have messages
        public OutOfBoundsException()
        {

        }

        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
