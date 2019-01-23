using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    class Frog1
    {
        public readonly int TongueLength;
        public readonly int ReactionTime;

        public Frog1(int tongueLength, int reactionTime)
        {
            TongueLength = tongueLength;
            ReactionTime = reactionTime;
        }

        public bool EatFly(int distanceToFly)
        {
            return TongueLength >= distanceToFly;
        }

        public bool EatFly(int distanceToFly, int flyReactionTime)
        {
            return TongueLength >= distanceToFly && ReactionTime <= flyReactionTime;
        }
    }
}
