
using WindowsApp.Algorithms.Sorting;
using WindowsApp.Algorithms.Comparing;
using WindowsApp.Algorithms.Arrays;
using WindowsApp.Algorithms.Caeser;
namespace WindowsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================== Welcome to my github repository ====================");
            BubbleSort.TestBubbleSort();
            LargestNumberAlgorithm.TestLargestNumber();
            SecondLargestNumberAlgorithms.TestFindSecondLargest();
            SmallestNumberAlgorithm.TestSmallestNumber();
            FindMissingNumber.TestMissingNumber();
            SumArrayElements.TestSumOfElementsInArray();
            CaeserEncryption.TestCaeserENC();
            CaeserDecryption.TestCaeserDEC();
        }
    }
}