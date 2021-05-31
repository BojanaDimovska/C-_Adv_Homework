using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Domain.Classes
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public Fish(string color, string size, string name, string type, int age) : base (name, type, age)
        {
            Color = color;
            Size = size;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is a {Size} {Color} fish.");
        }
    }
}
