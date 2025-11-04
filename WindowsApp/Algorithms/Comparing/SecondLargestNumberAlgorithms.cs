using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Algorithms.Comparing
{
    class SecondLargestNumberAlgorithms
    {
        // Function to find the second largest number in an array
        public static int FindSecondLargest(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                throw new ArgumentException("Array must contain at least two elements.");
            }
            int firstLargest = int.MinValue;
            int secondLargest = int.MinValue;
            foreach (int number in numbers)
            {
                if (number > firstLargest)
                {
                    secondLargest = firstLargest;
                    firstLargest = number;
                }
                else if (number > secondLargest && number != firstLargest)
                {
                    secondLargest = number;
                }
            }
            if (secondLargest == int.MinValue)
            {
                throw new InvalidOperationException("There is no second largest number.");
            }
            return secondLargest;
        }

        // Test method for FindSecondLargest
        public static void TestFindSecondLargest()
        {
            int[] array = { 12, 35, 1, 10, 34, 1 };
            int result = FindSecondLargest(array);
            Console.WriteLine("The second largest number is: " + result);
            // Expected output: The second largest number is: 34
        }
    }
}
