using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    class Ternary
    {
        public Ternary()
        {
            int value = -1;
            string textColor = null;

            /*if (value < 0)
            {
                textColor = "red";
            }
            else
            {
                textColor = "green";
            }*/

            textColor = (value < 0) ? "red" : "green";
        }
    }
}
