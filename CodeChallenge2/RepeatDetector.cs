using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge2
{
    class RepeatDetector : SequenceDetector
    {
        public override string Description => "Detects repetitions";

        public override bool Scan(int[] sequence)
        {
            if (sequence.Length < 2)
            {
                return false;
            }

            for (int i = 1; i < sequence.Length; ++i)
            {
                if (sequence[i] == sequence[i - 1])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
