using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Algorithms.Arrays
{
    class FindMissingNumber
    {
        public static int MissingNumber(int[] arr)
        {
            int count = 1;
            int Missing = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                count++;
                if ((arr[i + 1] - arr[i]) != 1)
                {
                    Missing = count;
                    break;
                }
            }
            return Missing;
        }
        public static void TestMissingNumber()
        {
            int[] arr = { 1, 2, 3, 5, 6 };
            int result = MissingNumber(arr);
            Console.WriteLine("The missing number is: " + result);
            // Expected output: The missing number is: 4
        }

    }
}
