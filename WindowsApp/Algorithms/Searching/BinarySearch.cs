
namespace WindowsApp.Algorithms.Searching
{
    public class BinarySearch
    {
        public static int Search(int[] arr, int target)
        {
            if (arr.Length <=1 || target == null) return -1;
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                {
                    return mid; // Target found
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1; // Search in the right half
                }
                else
                {
                    right = mid - 1; // Search in the left half
                }
            }
            return -1; // Target not found
        }
        public static void TestBinarySearch()
        {
            int[] arr = { 1, 3, 5, 7, 9, 11 };
            int target = 7;
            int result = Search(arr, target);
            Console.WriteLine("Target found at index: " + result);
            // Expected output: Target found at index: 3
        }
    }
}
