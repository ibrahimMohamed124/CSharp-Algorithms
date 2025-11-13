using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Algorithms.Searching
{
    public class LinearSearching
    {
        public static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]  == target)
                {
                    return i;
                }
            }
            return -1;
        }

    public static void TestLinearSearch()
        {
            int[] ints = { 1, 3, 4, 6, 8 };
            int target = 8;
            int res = LinearSearch(ints, target);
            if(res == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine($"{target} Found at index {res}");
            }
        }
    }
}
