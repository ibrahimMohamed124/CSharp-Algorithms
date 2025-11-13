using System;
using System.Text;

namespace WindowsApp.Algorithms.StringOperations
{
    public class ReverseString
    {
        public static StringBuilder Reverse(string str)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed.Append(str[i]);
            }
            return reversed;
        }

        public static void TestReverseString()
        {
            string str = "abc";
            Console.WriteLine(str);
            Console.WriteLine(Reverse(str));
        }
    }
}
