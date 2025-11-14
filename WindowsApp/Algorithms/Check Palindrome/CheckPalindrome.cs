using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Algorithms.Check_Palindrome
{
    class CheckPalindrome
    {
        public static bool isPalindrome(string str)
        {
            if (str.Equals(null)) throw new ArgumentException("String Cannot be null");

            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        public static void TestCheckPalindrome()
        {
            string str = "racecar";
            bool result = isPalindrome(str);
            Console.WriteLine($"Is '{str}' a palindrome? {result}");
            // Expected output: Is 'racecar' a palindrome? True
        }
    }
}
