using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Algorithms.LikesSystem
{
    public class LikesSystem
    {
        public static string WhoLikesIt(string[] names)
        {
            return names.Length switch
            {
                0 => "no one likes this",
                1 => $"{names[0]} likes this",
                2 => $"{names[0]} and {names[1]} like this",
                3 => $"{names[0]}, {names[1]} and {names[2]} like this",
                _ => $"{names[0]}, {names[1]} and {names.Length - 2} others like this"
            };
        }
        public static void TestWhoLikesIt()
        {
            string[] input1 = { };
            string[] input2 = { "Ibrahim" };
            string[] input3 = { "Mohamed", "Adham" };
            string[] input4 = { "Nora", "Ayman", "Adel" };
            string[] input5 = { "Ahmed", "Mahmoud", "Sara", "Kamal" };
            Console.WriteLine(WhoLikesIt(input1)); // no one likes this
            Console.WriteLine(WhoLikesIt(input2)); // Alice likes this
            Console.WriteLine(WhoLikesIt(input3)); // Bob and Charlie like this
            Console.WriteLine(WhoLikesIt(input4)); // Dave, Eve and Frank like this
            Console.WriteLine(WhoLikesIt(input5)); // Grace, Heidi and 2 others like this
        }

    }
}
