namespace WindowsApp.Algorithms
{
    class BubbleSort
    {
        public static void Sort(int[] array)
        {
            int length = array.Length;
            bool swapped;
            for (int i = 0; i < length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap array[j] and array[j + 1]
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }
                // If no two elements were swapped in the inner loop, then break
                if (!swapped)
                    break;
            }
        }

        public static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void TestBubbleSort()
        {
            int[] array = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Original array:");
            PrintArray(array);
            Sort(array);
            Console.WriteLine("Sorted array:");
            PrintArray(array);
        }
    }
}
