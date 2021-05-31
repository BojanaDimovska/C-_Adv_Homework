using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Classes
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }

        public Bike(string color, int id, string type, int yearOfProduction, int batchNum) : base(id, type, yearOfProduction, batchNum)
        {
            Color = color;
            Type = type;
            YearOfProduction = yearOfProduction;
            BatchNumber = batchNum;
        }

        public override void PrintVehicle()
        {
            Console.WriteLine("Bike:");
            Console.WriteLine($"Year of Production: {YearOfProduction}, Color: {Color}");
        }
    }
}
