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


                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
