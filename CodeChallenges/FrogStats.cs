using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    class FrogStats
    {
        public static double GetAverageTongueLength(Frog[] frogs)
        {
            double totalTongueLength = 0.0;

            /*for (int i = 0; i < frogs.Length; i++)
            {
                Frog frog = frogs[i];
                totalTongueLength += frog.TongueLength;
            }*/

            foreach (Frog frog in frogs)
            {
                totalTongueLength += frog.TongueLength;
            }

            return totalTongueLength / frogs.Length;
        }
    }
}
