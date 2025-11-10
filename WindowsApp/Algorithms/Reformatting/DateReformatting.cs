using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Algorithms.Reformatting
{
    public class DateReformatting
    {
        // mm/dd/yyyy
        public static string ReformatDate(string date)
        {
            string[] parts = date.Split("/");
            if (parts.Length != 3) return "Invalid Date Format";
            string year = parts[2];
            string month = parts[1];
            string day = parts[0];
            return $"{year} / {month} / {day}";
        }

        public static void TestReformatDate()
        {
            string inputDate = "10/Nov/2025";
            string reformatted = ReformatDate(inputDate);
            Console.WriteLine($"Original: {inputDate}");
            Console.WriteLine($"Reformatted: {reformatted}");
        }
    }
}
