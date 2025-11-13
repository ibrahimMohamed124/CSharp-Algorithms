using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Algorithms.Scrumblies
{
    public class Scrumblies
    {
        public static bool Scramble(string source, string target)
        {
            // Convert source string to a dictionary of character counts
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (char c in source)
            {
                if (charCounts.ContainsKey(c))
                    charCounts[c]++;
                else
                    charCounts[c] = 1;
            }

            // Check that every character in target exists in source with enough count
            foreach (char c in target)
            {
                if (!charCounts.ContainsKey(c) || charCounts[c] == 0)
                    return false;

                charCounts[c]--;
            }

            return true;
        }

        public static void TestScrumble()
        {
            Console.WriteLine(Scramble("rkqodlw", "world")); // True
            Console.WriteLine(Scramble("rkqodw", "world")); // False
        }
    }
}
