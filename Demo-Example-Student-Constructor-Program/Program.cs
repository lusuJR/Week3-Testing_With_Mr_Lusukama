using Demo_Example_Student_Constructor_Program;
using System;

namespace Demo_Example_Student_Constructor_Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine()!;

            Console.Write("Enter student age: ");

            int age;

            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("Invalid input. Please enter a valid age: ");
            }

            Student s = new Student(name, age);

            s.DisplayInfo();
        }
    }
}