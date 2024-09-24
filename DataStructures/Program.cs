using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a Topic for the Data Structures : ");
            Console.WriteLine("1. Introduction to Classes and Objects (Part 1 and Part 2)");
            Console.WriteLine("2. Linked List");
            Console.WriteLine("3. Stack and Queues");
            Console.WriteLine("4. Trees");
            Console.WriteLine("5. Graphs and Hash");

            Console.Write("\nEnter your choice : ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\n***Introduction to Classes and Objects (Part 1 and Part 2)***\n");
                    Person ce = new Person("Emmanuel", 24, "Matina Aplaya");
                    Dog l = new Dog("Loki", "Black", false);
                    ce.dog = l;
                    l.barkingWhileStandingUp();
                    ce.selfIntroduce();

                    Person ra = new Person("Russell Ann", 24, "Catalunan Pequino");
                    Dog m = new Dog("Moshi", "White", true);
                    ra.dog = m;
                    m.barkingWhileSittingDown();
                    ra.selfIntroduce();
                    break;
                case 2:
                    Console.WriteLine("\n***Linked List Operations***\n");
                    Node head = new Node(2);
                    Node second = new Node(4);
                    Node third = new Node(6);
                    Node fourth = new Node(10);

                    head.next = second;
                    second.next = third;
                    third.next = fourth;

                    Console.WriteLine("The linked list contains:");
                    head.printlist(head);

                    int nodeCount = head.countNodes(head);
                    Console.WriteLine("Number of nodes in the linked list: " + nodeCount);
                    break;
                case 3:
                    Console.WriteLine("\n***Stack and Queues***\n");
                    StackAndQueues sq = new StackAndQueues();
                    Console.WriteLine("Enter a string to check if it is a Palindrome : ");
                    string input = Console.ReadLine();

                    bool result = sq.isPalindrome(input);
                    if (result)
                    {
                        Console.WriteLine($"\"{input}\" is a palindrome.");
                    }
                    else
                    {
                        Console.WriteLine($"\"{input}\" is not a palindrome.");
                    }
                    break;
                case 4:
                    Console.WriteLine("\n***Trees***\n");
                    BinaryTree tree = new BinaryTree();

                    tree.Insert(5);
                    tree.Insert(3);
                    tree.Insert(7);
                    tree.Insert(2);
                    tree.Insert(4);
                    tree.Insert(6);
                    tree.Insert(8);

                    Console.Write("In-order Traversal of the Binary Tree : ");
                    tree.InOrderTraversal();
                    break;
                case 5:
                    Console.WriteLine("\n***Graphs and Hash***\n");
                    Graph graph = new Graph();
                    graph.AddEdge(1, 2);
                    graph.AddEdge(1, 3);
                    graph.AddEdge(2, 4);
                    graph.AddEdge(2, 5);
                    graph.AddEdge(3, 6);
                    graph.AddEdge(4, 7);

                    int reachableCount = graph.CountReachableNodes(1);
                    Console.WriteLine($"Number of reachable nodes from node 1: {reachableCount}");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
