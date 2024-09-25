using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class MinHeap
    {
        private List<int> heap = new List<int>();

        public void Insert(int value)
        {
            heap.Add(value);
            HeapifyUp(heap.Count - 1);
        }
        private void HeapifyUp(int index)
        {
            int parent = (index - 1) / 2;
            if (index > 0 && heap[index] < heap[parent])
            {
                Swap(index, parent);
                HeapifyUp(parent);
            }
        }
        private void Swap(int index1, int index2)
        {
            int temp = heap[index1];
            heap[index1] = heap[index2];
            heap[index2] = temp;
        }
        public int GetMin()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("Heap is empty.");
            return heap[0];
        }
        public int RemoveMin()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("Heap is empty.");

            int min = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);
            return min;
        }
        public void HeapifyDown(int index)
        {
            int smallest = index;
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 1;

            if (leftChild < heap.Count && heap[leftChild] < heap[smallest])
                smallest = leftChild;
            if (rightChild < heap.Count && heap[rightChild] < heap[smallest])
                smallest = rightChild;
            if(smallest != index)
            {
                Swap(index, smallest);
                HeapifyDown(smallest);
            }
        }
        public void DisplayHeap()
        {
            Console.WriteLine("Heap : " + string.Join(", ", heap));
        }
    }

    class Heap
    {
        public static void Heaps()
        {
            MinHeap mh = new MinHeap();

            while (true)
            {
                Console.WriteLine("\nMin-Heap Task Priority System");
                Console.WriteLine("1. Add task (Insert number into heap)");
                Console.WriteLine("2. Get highest-priority task (Minimum)");
                Console.WriteLine("3. Complete highest-priority task (Remove min)");
                Console.WriteLine("4. Display heap");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter task priority (number): ");
                        int value = int.Parse(Console.ReadLine());
                        mh.Insert(value);
                        Console.WriteLine($"Task with priority {value} added.");
                        break;

                    case 2:
                        try
                        {
                            Console.WriteLine($"Highest-priority task is: {mh.GetMin()}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case 3:
                        try
                        {
                            Console.WriteLine($"Completing task with priority: {mh.RemoveMin()}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case 4:
                        mh.DisplayHeap();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }

    
}
