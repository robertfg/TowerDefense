using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    class Frog2
    {
        private int _numFliesEaten;

        /*public int GetNumFliesEaten()
        {
            return _numFliesEaten;
        }

        public void SetNumFliesEaten(int numFliesEaten)
        {
            _numFliesEaten = numFliesEaten;
        }*/

        public int NumFliesEaten
        {
            get
            {
                return _numFliesEaten;
            }
            set
            {
                _numFliesEaten = value;
            }
        }
    }
}
