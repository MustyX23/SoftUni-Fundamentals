using System;
using System.Collections.Generic;

namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            List<Student> students = new List<Student>();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] tokens = command.Split(' ');

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];

                Student student = new Student(firstName, lastName, age, homeTown);

                bool exist = false;
                foreach (Student currentStudent in students)
                {
                    if (currentStudent.FirstName == student.FirstName 
                        && currentStudent.LastName == student.LastName)
                    {
                        currentStudent.Age = age;
                        currentStudent.HomeTown = homeTown;
                        exist = true;
                    }
                }
                if (!exist)
                {
                    students.Add(student);
                }

                command = Console.ReadLine();
            }

            string cityCommand = Console.ReadLine();

            for (int i = 0; i < students.Count; i++)
            {
                Student student = students[i];
                if (cityCommand == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
    
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }

        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
    }
}
