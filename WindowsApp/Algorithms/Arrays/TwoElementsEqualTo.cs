using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Algorithms.Arrays
{
    public class TwoElementsEqualTo
    {
        public TwoElementsEqualTo(int[] arr, int target)
        {
            var map = new Dictionary<int, int>();

            foreach (var number in arr)
            {
                int needed = target - number;

                if (map.ContainsKey(needed))
                {
                    Console.WriteLine($"Found: {needed} + {number} = {target}");
                    return;
                }

                if (!map.ContainsKey(number))
                    map[number] = 1;
            }

            Console.WriteLine("No match found");
        }
    }

}
