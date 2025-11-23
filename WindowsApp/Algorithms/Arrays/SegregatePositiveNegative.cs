// using System;

// namespace WindowsApp.Algorithms.Arrays
// {
//     public class SegregatePositiveNegative
//     {
//         private int[] array;

//         public SegregatePositiveNegative(int[] array)
//         {
//             this.array = array;
//             Segregate();
//         }

//         private void Segregate()
//         {
//             int i = 0;
//             int j = array.Length - 1;

//             while (i < j)
//             {
//                 while (array[i] < 0 && i < j) i++;
//                 while (array[j] >= 0 && i < j) j--;

//                 if (i < j)
//                 {
//                     Swap(i, j);
//                 }
//             }
//         }

//         private void Swap(int i, int j)
//         {
//             int temp = array[i];
//             array[i] = array[j];
//             array[j] = temp;
//         }

//         public static void PrintArray()
//         {
//             foreach (var item in array)
//             {
//                 Console.Write(item + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }
