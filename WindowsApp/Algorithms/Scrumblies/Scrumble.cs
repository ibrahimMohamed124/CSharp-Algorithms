using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Algorithms.Scrumblies
{
    public class Scrumblies
    {
        public static bool Scrumble(string str1, string str2)
        {
            List<char> str1CharsList = str1.ToList();
            List<char> str2CharsList = str2.ToList();
            if(str1CharsList.Count > str2CharsList.Count)
            {
                bool isSubset = str2CharsList.All(c => str1CharsList.Contains(c));
                return isSubset;
            }
            else
            {
                bool isSubset = str1CharsList.All(c => str2CharsList.Contains(c));
                return isSubset;
            }
        }

        public static void TestScrumble()
        {
            Console.WriteLine(Scrumble("rkqodlw", "world"));
            Console.WriteLine(Scrumble("rkqodw", "world"));
        }
    }
}
