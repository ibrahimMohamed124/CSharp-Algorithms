using System;

namespace WindowsApp.Algorithms.Comparing
{
    class SmallestNumberAlgorithm
    {
        public static int SmallestNumber(params int[] numbers)
        {
           
            if (numbers.Length == 0)
                throw new ArgumentException("At least one number is required.");

            int Smallest = numbers[0]; // نبدأ بأول عنصر

            foreach (int num in numbers)
            {
                if (num < Smallest)
                {
                    Smallest = num;
                }
            }

            return Smallest;
        }

        public static void TestSmallestNumber()
        {
            int result = SmallestNumber(3, 5, 7, 2, 8, 6);
            Console.WriteLine("The smallest number is: " + result);
            // Expected output: The smallest number is: 2
        }
    }
}
