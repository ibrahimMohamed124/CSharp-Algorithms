using System;

namespace WindowsApp.Algorithms.Reformatting
{
    public class DateReformatting
    {
        // Converts date formats like dd/MM/yyyy or dd-MMM-yyyy to yyyy/MM/dd
        public static string ReformatDate(string date)
        {
            if (string.IsNullOrWhiteSpace(date))
                return "Invalid Date";

            string[] parts = null;

            if (date.Contains('/'))
                parts = date.Split('/');
            else if (date.Contains('-'))
                parts = date.Split('-');
            else if (date.Contains(' '))
                parts = date.Split(' ');
            else
                return "Invalid Date Format";

            if (parts.Length != 3)
                return "Invalid Date Format";

            string day = parts[0].Trim();
            string month = parts[1].Trim();
            string year = parts[2].Trim();

            return $"{year}/{month}/{day}";
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
