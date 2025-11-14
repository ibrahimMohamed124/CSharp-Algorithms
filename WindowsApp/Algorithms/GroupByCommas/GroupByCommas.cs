using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Algorithms.GroupByCommas
{
    public class GroupByCommas
    {
        public static string GroupNumbers(int number)
        {
            string numberStr = number.ToString();

            for (int i = numberStr.Length - 3; i > 0; i -= 3)
            {
                numberStr = numberStr.Insert(i, ",");
            }

            return numberStr;
        }

        public static void TestGroupNumbers()
        {
            int input = 1234567890;
            string output = GroupNumbers(input);
            Console.WriteLine("Input: " + input);
            Console.WriteLine("Output: " + output);
        }
    }
}
