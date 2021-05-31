using System;
using System.Collections.Generic;
using System.Text;
using Task1.Domain.Classes;

namespace Task1.Domain
{
    public static class PrintHelper
    {
        public static void PrintInfo(this Shape shape)
        {
            Console.WriteLine($"Id: {shape.Id}, Type:{shape.GetType()}");
        }
    }
}
