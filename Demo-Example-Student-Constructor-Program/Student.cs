using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Example_Student_Constructor_Program
{
    public class Student
    {
        private string name;
        private int age;

        public Student(string studentName, int studentAge)
        {
            name = studentName;
            age = studentAge;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }
    }
}
