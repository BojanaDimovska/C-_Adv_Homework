using System;
using Task1.Domain;
using Task1.Domain.Classes;

namespace Task1.App
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericDb<Shape>.Shapes.Add(new Circle() { Id = 1, Radius = 3 });
            GenericDb<Shape>.Shapes.Add(new Rectangle() { Id = 2, SideA = 2, SideB = 2.5 });

            Console.WriteLine("Area of the shapes:");
            GenericDb<Shape>.PrintAreas();

            Console.WriteLine("Perimeter of the shapes:");
            GenericDb<Shape>.PrintPerimeters();


            Shape circle = GenericDb<Shape>.Shapes[0];
            circle.PrintInfo();

            Shape rectangle = GenericDb<Shape>.Shapes[1];
            rectangle.PrintInfo();

            Console.ReadLine();
        }
    }
}
