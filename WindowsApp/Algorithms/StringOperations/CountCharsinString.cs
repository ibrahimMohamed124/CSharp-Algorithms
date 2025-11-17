using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Algorithms.StringOperations
{
    public class CountCharsinString
    {
        public static Dictionary<char, int> Count(string str)
        {
            var result = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (result.ContainsKey(c))
                    result[c]++; // value increment
                else
                    result[c] = 1; // initial value
            }

            return result;
        }

    public static void TestCountChars()
        {
            string str = "hello world";
            var charCount = CountCharsinString.Count(str);
            Console.WriteLine($"Character counts in '{str}':");
            foreach (var kvp in charCount)
            {
                Console.WriteLine($"'{kvp.Key}': {kvp.Value}");
            }
            // Expected output:
            // 'h': 1
            // 'e': 1
            // 'l': 3
            // 'o': 2
            // ' ': 1
            // 'w': 1
            // 'r': 1
            // 'd': 1
        }
    }
}
