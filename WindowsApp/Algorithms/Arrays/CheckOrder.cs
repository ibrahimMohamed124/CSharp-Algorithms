using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Algorithms.Arrays
{
    public class CheckArrayOrder
    {
        public static string CheckOrder(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1]) continue;
                if (arr[i] > arr[i + 1]) return "Descending";
                else return "Ascending";
            }
            return "Already Ordered";
        }

        public static void TestCheckArrayOrder()
        {
            int[] arr1 = { 1,1,1,1 };
            int[] arr2 = { 1, 2 ,3 ,4 };
            Console.WriteLine(CheckOrder(arr1));
            Console.WriteLine(CheckOrder(arr2));

        }
    }
}
