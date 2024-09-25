using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Hashing
    {
        public static void HashTablesAndDict()
        {
            Dictionary<string, int> studentGrades = new Dictionary<string, int>();

            studentGrades.Add("Juan", 85);
            studentGrades.Add("Maria", 90);
            studentGrades.Add("Pedro", 78);

            while (true)
            {
                Console.WriteLine("\nStudent Grading System");
                Console.WriteLine("1. Add Student and Grade");
                Console.WriteLine("2. Get Student Grade");
                Console.WriteLine("3. Display All Students and Grades");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter student grade: ");
                        int grade = int.Parse(Console.ReadLine());

                        if (!studentGrades.ContainsKey(name))
                        {
                            studentGrades.Add(name, grade);
                            Console.WriteLine($"Student {name} added with grade {grade}.");
                        }
                        else
                        {
                            Console.WriteLine($"Student {name} already exists.");
                        }
                        break;

                    case 2:
                        Console.Write("Enter student name to search: ");
                        string searchName = Console.ReadLine();

                        if (studentGrades.TryGetValue(searchName, out int retrievedGrade))
                        {
                            Console.WriteLine($"{searchName}'s grade is: {retrievedGrade}");
                        }
                        else
                        {
                            Console.WriteLine($"{searchName} not found.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nAll Students and Grades:");
                        foreach (var student in studentGrades)
                        {
                            Console.WriteLine($"Student: {student.Key}, Grade: {student.Value}");
                        }
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }
    }
}
