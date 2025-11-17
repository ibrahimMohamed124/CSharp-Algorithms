using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Algorithms.StringOperations
{
    public class AddTwoNumberWithStrings
    {
        public static string Add(string a, string b)
        {
            double doubleA = double.Parse(a);
            double doubleB = double.Parse(b);
            double res = doubleA + doubleB;
            return res.ToString();
        }
    }
}
