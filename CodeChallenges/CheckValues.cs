using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    class CheckValues
    {
        public CheckValues()
        {
            int value = int.Parse(Console.ReadLine());

            try
            {
                if (value < 0 || value > 20)
                {
                    throw new System.Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Value is out of bounds!");
            }

            Console.WriteLine(string.Format("You entered {0}", value));
        }
    }
}
