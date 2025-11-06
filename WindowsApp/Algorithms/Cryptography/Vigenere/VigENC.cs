using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Algorithms.Cryptography.Vigenere
{
    class VigENC
    {
        public static string Encrypt(string plainText, string key)
        {
            StringBuilder cipherText = new StringBuilder();
            int keyIndex = 0;
            foreach (char ch in plainText)
            {
                if (char.IsLetter(ch))
                {
                    char offset = char.IsUpper(ch) ? 'A' : 'a';
                    char keyChar = char.IsUpper(key[keyIndex % key.Length]) ? key[keyIndex % key.Length] : char.ToUpper(key[keyIndex % key.Length]);
                    int encryptedChar = (ch - offset + (keyChar - 'A')) % 26 + offset;
                    cipherText.Append((char)encryptedChar);
                    keyIndex++;
                }
                else
                {
                    cipherText.Append(ch);
                }
            }
            return cipherText.ToString();
        }

        public static void TestVigENC()
        {
            string plainText = "AttackAtDawn";
            string key = "LEMON";
            string result = Encrypt(plainText, key);
            Console.WriteLine("The encrypted text is: " + result);
            // Expected output: The encrypted text is: LxfopvEfRnhr
        }
    }
}
