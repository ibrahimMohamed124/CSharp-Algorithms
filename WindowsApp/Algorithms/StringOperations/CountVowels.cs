using System;

namespace WindowsApp.Algorithms.StringOperations
{
    public class VowelsCounter
    {
        public static int CountVowels(string str)
        {
        int vowelCount = 0;
        List<char> vowels =new List<char>(){'a','e','i','o','u'};
        foreach (char c in str)
        {
            if(vowels.Contains(c)) vowelCount++;
        }
            return vowelCount;
        }
    }
}

