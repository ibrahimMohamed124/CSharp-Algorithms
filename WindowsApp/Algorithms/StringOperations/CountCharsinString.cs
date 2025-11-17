using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Algorithms.StringOperations
{
    public class CountCharsinString
    {
        public static Dictionary<char,int> Count(string str)
        {
             var result = new Dictionary<char, int>();

        foreach (char c in str)
        {
            if (result.ContainsKey(c))
                result[c]++;
            else
                result[c] = 1;
        }

        return result;
        }
    }
}
