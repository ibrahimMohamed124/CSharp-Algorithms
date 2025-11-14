
namespace WindowsApp.Algorithms.Check_Anagram
{
    class isAnagram
    {
        public static bool IsAnagram(string str1, string str2) 
        {
            if (str1.Equals(null)) throw new ArgumentException("String Cannot be null");

            string a = str1.ToLower();
            string b = str2.ToLower();
            List<char> list_a = str1.ToList();
            List<char> list_b = str2.ToList();
            list_a.Sort();
            list_b.Sort();
            if(list_a.SequenceEqual(list_b)) // Compares Two Lists
            {
                return true;
            }
            return false;
        }

        public static void TestIsAnagram() 
        {
            string a = "abc";
            string b = "cba";
            bool res = IsAnagram(a, b);
            if(res == true) Console.WriteLine("These Strings are Anagram");
            else Console.WriteLine("These Strings are not Anagram");
            // Output: These Strings are Anagram
        }
    }
}
