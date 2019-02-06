using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            Console.WriteLine(b.Name);

            Sub s = new Sub();
            Console.WriteLine(s.Name);

            // No override (new): Base
            // Override: Sub
            Base b1 = new Sub();
            Console.WriteLine(b1.Name);

            Console.ReadLine();

        }
    }
}
