using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class SortingAlgo
    {
        public static void QuickSort(int[] arr, int left, int right)
        {
            
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                QuickSort(arr, left, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, right);
            }
        }

        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp1;

            return i + 1;
        }
        public static void SelectionSort(int[] arr)
        {
            int num = arr.Length;

            for (int i = 0; i < num; i++)
            {
                int minIndex = i;

                for(int j = i + 1;j < num; j++)
                {
                    if( arr[j] <= arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
    }
    class SortingAlgorithm
    {
        public static void AllSorting()
        {
            Console.Write("How many inputs do you want? : ");
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                Console.Write($"In index {i} : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Types of Sorting Algorithm:\n[1] Quick Sort" +"\n[2] Selection Sort");
            Console.Write("\nChoose the type of Sorting Algorithm you want to perform: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SortingAlgo.QuickSort(numbers, 0, numbers.Length - 1);
                    Console.WriteLine("Array sorted using QuickSort: ");
                    break;
                case 2:
                    SortingAlgo.SelectionSort(numbers);
                    Console.WriteLine("Array sorted using Selection Sort: ");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }
            Console.WriteLine("Sorted Array : ");
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
