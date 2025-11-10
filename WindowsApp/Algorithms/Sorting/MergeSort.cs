using System;

namespace WindowsApp.Algorithms.Sorting
{
    public class MergeSortAlgorithm
    {
        static double[] MergeSort(double[] arr)
        {
            if (arr.Length <= 1)
                return arr;

            int mid = arr.Length / 2;
            double[] leftHalf = new double[mid];
            double[] rightHalf = new double[arr.Length - mid];

            Array.Copy(arr, 0, leftHalf, 0, mid);
            Array.Copy(arr, mid, rightHalf, 0, arr.Length - mid);

            double[] sortedLeft = MergeSort(leftHalf);
            double[] sortedRight = MergeSort(rightHalf);

            return Merge(sortedLeft, sortedRight);
        }

        static double[] Merge(double[] left, double[] right)
        {
            List<double> result = new List<double>();
            int i = 0, j = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            while (i < left.Length)
            {
                result.Add(left[i]);
                i++;
            }

            while (j < right.Length)
            {
                result.Add(right[j]);
                j++;
            }

            return result.ToArray();
        }
    }
}
