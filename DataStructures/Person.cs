using System;

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




}
