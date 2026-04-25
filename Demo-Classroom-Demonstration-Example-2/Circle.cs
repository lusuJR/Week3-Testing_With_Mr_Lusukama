using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Classroom_Demonstration_Example_2
{
    class Circle
    {
        private double radius;

        public void SetRadius(double r)
        {
            radius = r;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

    }
}
