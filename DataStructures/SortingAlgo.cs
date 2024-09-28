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

        public static void BubbleSort(int[] arr)
        {
            int num = arr.Length;

            for (int i = 0; i < num - 1; i++)
            {
                bool swapped = false;

                for(int j = 0; j < num - i - 1;  j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j+1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }

        public static void InsertionSort(int[] arr)
        {
            int num = arr.Length;

            for(int i = 1; i < num; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j+1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        public static void MergeSort(int[] arr, int left, int right)
        {
            if(left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        public static void Merge(int[] arr, int left, int mid, int right)
        {
            int num1 = mid - left + 1;
            int num2 = right - mid;

            int[] L = new int[num1];
            int[] R = new int[num2];

            for (int i = 0; i < num1; i++)
                L[i] = arr[left + i];
            for (int i = 0; i < num2; i++)
                R[i] = arr[mid + 1 + i];


            int iLeft = 0, iRight = 0;
            int k = left;

            while (iLeft < num1 && iRight < num2)
            {
                if (L[iLeft] <= R[iRight])
                {
                    arr[k] = L[iLeft];
                    iLeft++;
                } else
                {
                    arr[k] = R[iRight];
                    iRight++;
                }
                k++;
            }
            while(iLeft < num1)
            {
                arr[k] = L[iLeft];
                iLeft++;
                k++;
            }
            while(iRight < num2)
            {
                arr[k] = R[iRight];
                iRight++;
                k++;
            }
        }

        public static void HeapSort(int[] arr)
        {
            int num = arr.Length;

            for (int i = num / 2 - 1; i >= 0; i--)
                Heapify(arr, num, i);

            for(int i = num - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr, i, 0);
            }
        }

        public static void Heapify(int[] arr, int num, int largestNum)
        {
            int largest = largestNum;
            int left = 2 * largestNum + 1;
            int right = 2 * largestNum + 2;

            if (left < num && arr[left] > arr[largest])
                largest = left;
            if (right < num && arr[right] > arr[largest])
                largest = right;
            if (largest != largestNum)
            {
                int swap = arr[largestNum];
                arr[largestNum] = arr[largest];
                arr[largest] = swap;
                Heapify(arr, num, largest);
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

            Console.Write("Types of Sorting Algorithm:\n[1] Quick Sort" +"\n[2] Selection Sort" + "\n[3] Bubble Sort" + "\n[4] Insertion Sort"
                + "\n[5] Merge Sort" + "\n[6] Heap Sort");
            Console.Write("\nChoose the type of Sorting Algorithm you want to perform: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SortingAlgo.QuickSort(numbers, 0, numbers.Length - 1);
                    Console.Write("\nArray sorted using QuickSort");
                    break;
                case 2:
                    SortingAlgo.SelectionSort(numbers);
                    Console.Write("\nArray sorted using Selection Sort : ");
                    break;
                case 3:
                    SortingAlgo.BubbleSort(numbers);
                    Console.Write("\nArray sorted using Bubble Sort : ");
                    break;
                case 4:
                    SortingAlgo.InsertionSort(numbers);
                    Console.Write("\nArray sorted using Insertion Sort: ");
                    break;
                case 5:
                    SortingAlgo.MergeSort(numbers, 0, numbers.Length - 1);
                    Console.Write("\nArray sorted using Merge Sort: ");
                    break;
                case 6:
                    SortingAlgo.HeapSort(numbers);
                    Console.Write("\nArray sorted using Heap Sort: ");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }
            Console.Write("\nSorted Array : ");
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
