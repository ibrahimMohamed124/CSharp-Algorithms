using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApp.Algorithms.MorseCode
{
    public static class MorseCodeDecoder
    {
        public static string Decode(string morseCode)
        {
            var MorseCodeDict = new Dictionary<string, string>
        {
            // Letters
            {".-", "A"}, {"-...", "B"}, {"-.-.", "C"}, {"-..", "D"},
            {".", "E"}, {"..-.", "F"}, {"--.", "G"}, {"....", "H"},
            {"..", "I"}, {".---", "J"}, {"-.-", "K"}, {".-..", "L"},
            {"--", "M"}, {"-.", "N"}, {"---", "O"}, {".--.", "P"},
            {"--.-", "Q"}, {".-.", "R"}, {"...", "S"}, {"-", "T"},
            {"..-", "U"}, {"...-", "V"}, {".--", "W"}, {"-..-", "X"},
            {"-.--", "Y"}, {"--..", "Z"},

            // Numbers
            {"-----", "0"}, {".----", "1"}, {"..---", "2"}, {"...--", "3"},
            {"....-", "4"}, {".....", "5"}, {"-....", "6"}, {"--...", "7"},
            {"---..", "8"}, {"----.", "9"},

            // Special characters
            {".-.-.-", "."}, {"--..--", ","}, {"..--..", "?"}, {".----.", "'"},
            {"-.-.--", "!"}, {"-..-.", "/"}, {"-.--.", "("}, {"-.--.-", ")"},
            {".-...", "&"}, {"---...", ":"}, {"-.-.-.", ";"}, {"-...-", "="},
            {".-.-.", "+"}, {"-....-", "-"}, {"..--.-", "_"}, {".-..-.", "\""},
            {"...-..-", "$"}, {".--.-.", "@"},

            // Special service codes
            {"...---...", "SOS"}
        };

            // Trim extra spaces
            morseCode = morseCode.Trim();

            var decoded = new StringBuilder();

            // Split words by 3 spaces
            string[] words = morseCode.Split(new string[] { "   " }, StringSplitOptions.None);

            foreach (var word in words)
            {
                string[] letters = word.Split(' ');
                foreach (var letter in letters)
                {
                    if (MorseCodeDict.ContainsKey(letter))
                        decoded.Append(MorseCodeDict[letter]);
                }
                decoded.Append(' '); // space between words
            }

            return decoded.ToString().Trim(); // remove trailing space
        }
    }
}
