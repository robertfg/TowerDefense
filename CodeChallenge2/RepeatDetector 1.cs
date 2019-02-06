using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge2
{
    class RepeatDetector1 : SequenceDetector
    {
        public override bool Scan(int[] sequence)
        {
            for (int i = 0; i < sequence.Length; i++)
            {
                if (i > 0)
                {
                    if (sequence[i] == sequence[i - 1])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
