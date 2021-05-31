using System;
using System.Collections.Generic;
using System.Text;
using Task1.Domain.Classes;

namespace Task1.Domain
{
    public static class GenericDb<T> where T : Shape
    {
        public static List<T> Shapes { get; set; }
        static GenericDb()
        {
            Shapes = new List<T>();
        }

        public static void PrintAreas()
        {
            foreach(T shape in Shapes)
            {
                Console.WriteLine(shape.GetArea());
            }
        }

        public static void PrintPerimeters()
        {
            foreach(T shape in Shapes)
            {
                Console.WriteLine(shape.GetPerimetar());
            }
        }
    }
}
