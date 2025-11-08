using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Algorithms.Delegates
{
    public class ExtractEvens
    {
        public static List<int> GetEvens(List<int> numbers) 
        {
            var getEvens = from num in numbers
                           where num % 2 == 0
                           select num;
            return getEvens.ToList();
        }

        public static bool IsEven(int number)
        {
            Predicate<int> isEven = num => num % 2 == 0;
            return isEven(number);
        }


        public static void TestGetEvenNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evens = GetEvens(numbers);
            Console.WriteLine("Even Numbers: " + string.Join(", ", evens));
            // Output: Even Numbers: 2, 4, 6, 8, 10
        }

        public static void TestIsEven()
        {
            int number = 4;
            bool result = IsEven(number);
            Console.WriteLine($"{number} is even: {result}");
            // Output: 4 is even: True
        }
    }
}
