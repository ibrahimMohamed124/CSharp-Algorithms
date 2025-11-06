namespace WindowsApp.Algorithms.Cryptography.Caeser
{
    class CaeserEncryption
    {
        public static string CaeserENC(string str, int key)
        {
            if (key.GetType() != typeof(int))
            {
                throw new ArgumentException("Key cannot be of any datatype other than integer");
            }
            if (key == null || str == null)
            {
                throw new ArgumentException("Text or Key Caannot be Null");
            }

            string chars = "abcdefghijklmnopqrstuvwxyz";
            string encrypted = "";

            for (int i = 0; i < str.Length; i++)
            {
                int index = chars.IndexOf(str[i]);
                int encryptedIdnex = (index + key) % chars.Length;
                encrypted += chars[encryptedIdnex];
            }
            return encrypted;
        }

        public static void TestCaeserENC()
        {
            string text = "ibrahim";
            int key = 3;
            string result = CaeserENC(text, key);
            Console.WriteLine("The encrypted text is: " + result);
            // Expected output: The encrypted text is: leudklp
        }

    }
}
