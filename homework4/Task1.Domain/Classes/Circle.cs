using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Domain.Classes
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            if(Radius <= 0)
            {
                Console.WriteLine("Invalid input! Radius can't be 0 or less than 0");
            }
            return 3.14 * Radius * Radius;
        }
        public override double GetPerimetar()
        {
            if(Radius <= 0)
            {
                Console.WriteLine("Invalid input! Radius can't be 0 or less than 0");
            }
            return 2 * 3.14 * Radius;
        }
    }
}
