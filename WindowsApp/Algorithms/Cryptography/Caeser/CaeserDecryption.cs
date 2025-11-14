using static WindowsApp.Algorithms.Cryptography.Caeser.CaeserEncryption;

namespace WindowsApp.Algorithms.Cryptography.Caeser
{
    class CaeserDecryption
    {
        public static string CaeserDEC(string str, int key)
        {
            if (key <= 0) return "Key cannot be less than1";
            if (str.Equals(null)) return "Text Cannot be null";
            return CaeserENC(str, -key);
        }

        public static void TestCaeserDEC()
        {
            string text = "leudklp";
            int key = 3;
            string result = CaeserDEC(text, key);
            Console.WriteLine("The deccrypted text is: " + result);
            // Expected output: The deccrypted text is: ibrahim
        }
    }
}
