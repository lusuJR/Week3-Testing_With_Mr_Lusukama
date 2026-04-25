using System;

namespace Example_understand_classification
{ 
    class Program
    {
       
        static void Main(string[] args)
        {
            //add code here to create an instance of the Car class and call its DisplayInfo method
            Car car = new();
            Car myCar = car;
            myCar.id = 1;
            myCar.Brand = "Toyota";
            myCar.Speed = 120;
            myCar.DisplayInfo();
            car.Brand = "Honda";
            myCar.DisplayInfo(); 

        }
}
}