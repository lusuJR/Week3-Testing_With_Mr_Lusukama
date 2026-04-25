using System;


namespace Demo_Classroom_Demonstration_Example_2
{
    public class Program
    {
        static void Main()
        {
            Circle myCircle = new Circle();

            Console.Write("Enter the radius of the circle: ");

            double userRadius;

            while (!double.TryParse(Console.ReadLine(), out userRadius))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            myCircle.SetRadius(userRadius);

            Console.WriteLine($"Area = {myCircle.GetArea():F2}");
        }
    }
}