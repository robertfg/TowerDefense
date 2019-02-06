using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges4
{
    class Program
    {
        static void Main(string[] args)
        {
            VocabularyWord word1 = new VocabularyWord("happy");
            VocabularyWord word2 = new VocabularyWord(null);

            Console.WriteLine(word1.Equals(word2));
            Console.ReadLine();
        }
    }
}
