using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Frog1 mike = new Frog1(5, 3);

            Frog[] frogs = new Frog[5];

            frogs[0] = new Frog();
            frogs[1] = new Frog();
            frogs[2] = new Frog();
            frogs[3] = new Frog();
            frogs[4] = new Frog();

            frogs[0].TongueLength = 5;
            frogs[1].TongueLength = 10;
            frogs[2].TongueLength = 15;
            frogs[3].TongueLength = 20;
            frogs[4].TongueLength = 25;

            /* I would need a new class, e.g., cohort, to represent a group of frogs
             * to do what TowerDefense does in Game.cs with Path.   */

            /*Frog[] frogs = new Frog(
                new[]
                {
                    new Frog[0]
                }
            );*/

            Console.WriteLine(FrogStats.GetAverageTongueLength(frogs));
            Console.ReadLine();
        }
    }
}
