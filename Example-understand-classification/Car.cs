using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Example_understand_classification
{
    class Car
    {
        public int id;
        public string Brand;
        public int Speed;

        public void DisplayInfo()
        { 
            Console.WriteLine($"ID: {id}, Brand: {Brand}, Speed: {Speed}");
        }

       public void UpdateSpeed(int newSpeed)
        {
            Speed = newSpeed;
        }


    }
}
