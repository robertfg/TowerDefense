using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges4
{
    class VocabularyWord
    {
        public string Word { get; private set; }

        public override bool Equals(object word)
        {
            if ( word != null )
            {
                VocabularyWord that = word as VocabularyWord;
                return this.Word == that.Word;
            }
            return false;
        }

        public override string ToString()
        {
            return Word;
        }

        public override int GetHashCode()
        {
            return Word.GetHashCode() * 31;
        }

        public VocabularyWord(string word)
        {
            Word = word;
        }
    }
}
