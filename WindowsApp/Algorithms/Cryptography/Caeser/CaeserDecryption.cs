using static WindowsApp.Algorithms.Caeser.CaeserEncryption;

namespace WindowsApp.Algorithms.Caeser
{
    class CaeserDecryption
    {
        public static string CaeserDEC(string str, int key) => CaeserENC(str, -key);

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
