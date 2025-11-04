using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Algorithms.Comparing
{
    class LargestNumberAlgorithm
    {
        public static int LargestNumber(params int[] numbers)
        {
            int largest = 0;

            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }

            return largest;
        }

        public static void TestLargestNumber()
        {
            int result = LargestNumber(3, 5, 7, 2, 8, 6);
            Console.WriteLine("The largest number is: " + result);
            // Expected output: The largest number is: 8
        }
    }
}
