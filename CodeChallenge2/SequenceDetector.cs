using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge2
{
    class SequenceDetector
    {
        public virtual string Description => "";

        public int[] LastScannedSequence { get; protected set; }

        public virtual bool Scan(int[] sequence)
        {
            return true;
        }
    }
}
