using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    class Exceptions
    {
    }

    class TooBigException : System.Exception
    {
        public TooBigException(string message) : base(message)
        {

        }
    }
}
