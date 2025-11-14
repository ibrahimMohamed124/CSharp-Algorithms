using System;
using System.Text;

namespace WindowsApp.Algorithms.StringOperations
{
    public class ReverseString
    {
        public static StringBuilder Reverse(string str)
        {
            if (str == null)
                throw new ArgumentException("No String Value Added");

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
            Console.WriteLine("Original: " + str);
            Console.WriteLine("Reversed: " + Reverse(str));
        }
    }
}
