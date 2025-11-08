using System;

namespace WindowsApp.Algorithms.Sorting
{
    public class MergeSort
    {
        public static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                // Divide the array into two halves
                Sort(arr, left, mid);
                Sort(arr, mid + 1, right);

                // Merge the sorted halves
                Merge(arr, left, mid, right);
            }
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = arr[left + i];

            for (int j = 0; j < n2; j++)
                rightArray[j] = arr[mid + 1 + j];

            int iLeft = 0, iRight = 0, k = left;

            // Merge the two subarrays back into the main array
            while (iLeft < n1 && iRight < n2)
            {
                if (leftArray[iLeft] <= rightArray[iRight])
                    arr[k++] = leftArray[iLeft++];
                else
                    arr[k++] = rightArray[iRight++];
            }

            // Copy any remaining elements
            while (iLeft < n1)
                arr[k++] = leftArray[iLeft++];

            while (iRight < n2)
                arr[k++] = rightArray[iRight++];
        }

        // Test the algorithm
        public static void Main()
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };

            Console.WriteLine("Array before sorting:");
            Console.WriteLine(string.Join(", ", arr));

            Sort(arr, 0, arr.Length - 1);

            Console.WriteLine("Array after sorting:");
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
