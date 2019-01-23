using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    class Constants
    {
        public Constants()
        {
            //const int revenue = 125000;
            int revenue = 125000;
            const int redRevenue = 100000;
            const int yellowRevenue = 150000;
            const string redStr = "red";
            const string yellowStr = "yellow";
            const string greenStr = "green";

            string status = null;

            if (revenue < redRevenue)
            {
                status = redStr;
            }
            else if (revenue < yellowRevenue)
            {
                status = yellowStr;
            }
            else
            {
                status = greenStr;
            }

            Console.WriteLine(status);
        }
    }
}
