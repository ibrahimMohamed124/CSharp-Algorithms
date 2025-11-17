using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Algorithms.MorseCode
{
    public class MorseCodeEncoder
    {
        public static StringBuilder Encode(string text) 
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

            var encoded = new StringBuilder();
            foreach (char c in text.ToUpper())
            {
                if (c == ' ')
                {
                    encoded.Append("   "); // 3 spaces between words
                }
                else
                {
                    var morseCode = MorseCodeDict.FirstOrDefault(x => x.Value == c.ToString()).Key;
                    if (morseCode != null)
                    {
                        encoded.Append(morseCode + " "); // 1 space between letters
                    }
                }
            }
            return encoded;
        }
    }
}
