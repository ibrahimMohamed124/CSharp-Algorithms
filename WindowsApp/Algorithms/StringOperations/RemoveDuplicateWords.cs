using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Algorithms.StringOperations
{
    public class RemoveDuplicateWords
    {
        public static string RemoveDuplicates(string str) 
        {
            string[] words = str.Split(' ');
            HashSet<string> uniqueWords = new HashSet<string>();
            StringBuilder result = new StringBuilder();
            foreach (string word in words)
            {
                if (uniqueWords.Add(word))
                {
                    if (result.Length > 0)
                    {
                        result.Append(" ");
                    }
                    result.Append(word);
                }
            }
            return result.ToString();

        }

        public static void TestRemoveDuplicates()
        {
            string input = "This is is a test test string string";
            string output = RemoveDuplicates(input);
            Console.WriteLine("Input: " + input);
            Console.WriteLine("Output: " + output);
        }
    }
}
