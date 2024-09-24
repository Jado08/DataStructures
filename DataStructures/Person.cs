using System;
using System.Collections.Generic;

namespace DataStructures
{
    internal class Person //connected to case #1
    {
        public string name;
        public int age;
        public string address;
        public Dog dog; 
        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public void selfIntroduce()
        {
            Console.WriteLine("I am " + name + ". My age is " + age + " years old. I lived in " + address + ".");
            if (dog != null)
            {
                Console.WriteLine("I have a " + dog.color + " dog and the name of the dog is " + dog.dogname + ".");
                Console.WriteLine(dog.isBarking
                    ? "The dog is barking while sitting down: " + dog.isBarking
                    : "The dog is barking while standing up: " + dog.isBarking);
            }
        }
    }
    class Dog //connected to case # 1
    {
        public string dogname;
        public string color;
        public bool isBarking;
        public Person personOwned;

        public Dog(string dogname, string color, bool isBarking)
        {
            this.dogname = dogname;
            this.color = color;
            this.isBarking = isBarking;
        }
        public void barkingWhileSittingDown()
        {
            this.isBarking = true;
        }
        public void barkingWhileStandingUp()
        {
            this.isBarking = false;
        }
    }
    class Node //connected to case # 2
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
        public int countNodes(Node head)
        {
            int count = 1;
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
                count += 1;
            }
            return count;
        } 
        public void printlist(Node head)
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
    class StackAndQueues //connected to case # 3
    {
        public bool isPalindrome(string input)
        {
            Stack<char> stack = new Stack<char> ();
            Queue<char> queue = new Queue<char> ();

            string normalizeInput = Normalize(input);
            foreach (char c in normalizeInput)
            {
                stack.Push (c);
                queue.Enqueue (c);
            } while (stack.Count > 0 && queue.Count > 0)
            {
                if (stack.Pop() != queue.Dequeue())
                {
                    return false;
                }
            }
            return true;
        }
        private string Normalize(string input)
        {
            char[] arr = input.ToLower().ToCharArray();
            List<char> convertToLowerCaselist = new List<char>();

            foreach(char c in arr)
            {
                if (char.IsLetterOrDigit(c))
                {
                    convertToLowerCaselist.Add(c);
                }
            }
            return new string (convertToLowerCaselist.ToArray());
        }
    }
    class TreeNode //connected to case # 4
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
    class BinaryTree //connected to case # 4
    {
        private TreeNode root;

        public BinaryTree()
        {
            root = null;
        }
        public void Insert(int value)
        {
            root = InsertRec(root, value);
        }

        private TreeNode InsertRec(TreeNode node, int value)
        {

            if (node == null)
            {
                return new TreeNode(value);
            }

            if (value < node.Value)
            {
                node.Left = InsertRec(node.Left, value);
            }
            else
            {
                node.Right = InsertRec(node.Right, value);
            }

            return node;
        }
        public void InOrderTraversal()
        {
            InOrderRec(root);
        }

        private void InOrderRec(TreeNode node)
        {
            if (node != null)
            {
                InOrderRec(node.Left);    
                Console.Write(node.Value + " "); 
                InOrderRec(node.Right); 
            }
        }
    }




}
