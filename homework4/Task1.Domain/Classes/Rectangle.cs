using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Domain.Classes
{
    public class Rectangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public override double GetArea()
        {
           if(SideA <= 0 || SideB <= 0)
            {
                Console.WriteLine("Invalid input! Radius can't be 0 or less than 0");
            }
            return SideA * SideB;
        }

        public override double GetPerimetar()
        {
            if (SideA <= 0 || SideB <= 0)
            {
                Console.WriteLine("Invalid input! Radius can't be 0 or less than 0");
            }
            return 2 * (SideA + SideB);
        }
    }
}
