using WindowsApp.Algorithms.Sorting;
using WindowsApp.Algorithms.Comparing;
using WindowsApp.Algorithms.Arrays;
using WindowsApp.Algorithms.Searching;
using WindowsApp.Algorithms.Check_Palindrome;
using WindowsApp.Algorithms.Check_Anagram;
using WindowsApp.Algorithms.Cryptography.Caeser;
using WindowsApp.Algorithms.Cryptography.Vigenere;
using WindowsApp.Algorithms.Delegates;
using WindowsApp.Algorithms.Reformatting;
using WindowsApp.Algorithms.Scrumblies;
using WindowsApp.Algorithms.StringOperations;
using WindowsApp.Algorithms.GroupByCommas;
using WindowsApp.Algorithms.LikesSystem;
using WindowsApp.Algorithms.MorseCode;

namespace WindowsApp
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("==================== Welcome to my github repository ====================");
            //BubbleSort.TestBubbleSort(); // Added test call for BubbleSort
            //LargestNumberAlgorithm.TestLargestNumber(); // Added test call for LargestNumberAlgorithm
            //SecondLargestNumberAlgorithms.TestFindSecondLargest(); // Added test call for SecondLargestNumberAlgorithms
            //SmallestNumberAlgorithm.TestSmallestNumber(); // Added test call for SmallestNumberAlgorithm
            //FindMissingNumber.TestMissingNumber(); // Added test call for FindMissingNumber
            //SumArrayElements.TestSumOfElementsInArray(); // Added test call for SumArrayElements
            //CaeserEncryption.TestCaeserENC();  // Added test call for CaeserEncryption
            //CaeserDecryption.TestCaeserDEC(); // Added test call for CaeserDecryption
            //BinarySearch.TestBinarySearch(); // Added test call for BinarySearch
            //CheckPalindrome.TestCheckPalindrome(); // Added test call for CheckPalindrome
            //isAnagram.TestIsAnagram();  // Added test call for CheckAnagram
            //BruteForce.TestBruteForce(); // Added test call for BruteForce
            //VigENC.TestVigENC(); // Added test call for Vigenere Encryption
            //// VigDEC.TestVigDEC(); // Added test call for Vigenere Decryption // Currently Commented Out
            //ExtractEvens.TestGetEvenNumbers(); // Added test call for ExtractEvens
            //ExtractEvens.TestIsEven(); // Added test call for IsEven
            //DateReformatting.TestReformatDate(); // Added test call for reformat date
            //CheckArrayOrder.TestCheckArrayOrder(); // Added test call for chheck array order
            //Scrumblies.TestScrumble(); // Added test call for scramble
            //LinearSearching.TestLinearSearch(); // Added test call for linear search
            //ReverseString.TestReverseString(); // Added test for reverse string
            //RemoveDuplicateWords.TestRemoveDuplicates(); // Added test call for RemoveDuplicateWords
            // GroupByCommas.TestGroupNumbers(); // Added test call for GroupByCommas
            // LikesSystem.TestWhoLikesIt(); // Added test call for LikesSystem
            Console.WriteLine(MorseCodeDecoder.Decode(".- -... -.."));
        }
    }
}