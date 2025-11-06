using System;
using System.Text;

namespace WindowsApp.Algorithms.Cryptography.Caeser
{
    class BruteForce
    {
        public BruteForce(string str)
        {
            if(str == null)
            {
                throw new ArgumentException("Input string cannot be null");
            }
            for (int key = 1; key < 26; key++)
            {
                StringBuilder decrypted = new StringBuilder();

                foreach (char c in str)
                {
                    if (char.IsLetter(c))
                    {
                        char offset = char.IsUpper(c) ? 'A' : 'a';
                        char decryptedChar = (char)((c - offset - key + 26) % 26 + offset);
                        decrypted.Append(decryptedChar);
                    }
                    else
                    {
                        decrypted.Append(c);
                    }
                }

                Console.WriteLine($"Key {key}: {decrypted}");
            }
        }

        public static void TestBruteForce()
        {
            string encryptedMessage = "Khoor Zruog";
            BruteForce bf = new BruteForce(encryptedMessage);
            // Expected output: All possible decryptions for keys 1 to 25
            // The Plaintext "Hello World" should appear when the correct key (3) is used
        }
    }
}
