
namespace WindowsApp.Algorithms.Arrays
{
    class SumArrayElements
    {
        public static int SumOfElementsInArray(int[] arr)
        {
            if (arr.Equals(null)) throw new ArgumentException("Array Cannot be null");

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static void TestSumOfElementsInArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int result = SumOfElementsInArray(arr);
            Console.WriteLine("The sum of array elements is: " + result);
            // Expected output: The sum of array elements is: 15
        }
    }
}
