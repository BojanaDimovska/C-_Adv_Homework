using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Classes
{
     public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }

        public Vehicle(int id, string type, int yearOfProduction, int batchNum)
        {
            Id = id;
            Type = type;
            YearOfProduction = yearOfProduction;
            BatchNumber = batchNum;
        }

        public virtual void PrintVehicle()
        {
            Console.WriteLine("Vehicle:");
            Console.WriteLine($"Id:{Id} Type: {Type} Year of production: {YearOfProduction}");
        }

    }
}
