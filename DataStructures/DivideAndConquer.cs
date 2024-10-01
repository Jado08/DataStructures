using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class DivideAndConquer
    {
        public static int FindMax(int[] arr, int left, int right)
        {
            if(left == right)
            {
                return arr[left];
            }
            int middleNum = (left + right) / 2;

            int maxLeft = FindMax(arr, left, middleNum);
            int maxRight = FindMax(arr, middleNum + 1, right);

            return Math.Max(maxLeft, maxRight);
        }
        public static void MaxArray()
        {
            int[] arr = { 5, 6, 7, 20, 1, 64, 99, 3 };

            int maxElement = FindMax(arr, 0, arr.Length - 1);
            Console.Write($"The list of array are : {string.Join(", ",arr)}");
            Console.WriteLine();
            Console.Write($"The maximum element in the array : {maxElement}");
        }
    }
}
