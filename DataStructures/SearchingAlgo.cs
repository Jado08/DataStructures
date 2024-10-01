using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class SearchingAlgo
    {
        public static int BinarySearch(int[] arr, int targetNum)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int middle = (low + high) / 2;

                if (arr[middle] == targetNum)
                {
                    return middle; 
                }
                else if (arr[middle] > targetNum)
                {
                    high = middle - 1; 
                }
                else
                {
                    low = middle + 1; 
                }
            }

            return -1; 
        }

        public static void CallBinarySearch()
        {
            int[] arr = { 5, 10, 15, 20, 25, 30 };
            int target = 20;

            int resultNum = BinarySearch(arr, target);

            if (resultNum != 1)
            {
                Console.Write("The Target number is " + target + ". ");
                Console.Write($"Element found at index {resultNum} when using Binary Search.");
            }
            else
            {
                Console.Write("The Target number is " + target + ". ");
                Console.Write("\nElement not found when using Binary Search!");
            }
        } 

        public static int LinearSearch(int[] arr, int targetNum)
        {
            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] == targetNum)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void CallLinearSearch()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int target = 60;

            int resultNum = LinearSearch(arr, target);

            if (resultNum != 1)  
            {
                Console.Write("\nThe Target number is " + target + ". ");
                Console.Write($"Element found at index {resultNum} when using Linear Search.");
            }else
            {
                Console.Write("The Target number is " + target + ". ");
                Console.Write("\nElement not found when using Linear Search!");
            }
        }
    }
    class SearchingAlgorithm
    {
        public static void AllSearching()
        {
            SearchingAlgo.CallBinarySearch();
            SearchingAlgo.CallLinearSearch();
        }
    }
}
