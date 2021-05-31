using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Classes
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> Countries { get; set; }

        public Car(int fuelTank, List<string> countries, int id, string type, int yearOfProduction, int batchNum) : base(id, type, yearOfProduction, batchNum)
        {
            FuelTank = fuelTank;
            Countries = countries;
            Type = type;
            YearOfProduction = yearOfProduction;
            BatchNumber = batchNum;
        }
        public override void PrintVehicle()
        {
            Console.WriteLine("Car:");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine("Countries of production:");
            foreach(string car in Countries)
            {
                Console.WriteLine(car);
            }
        }
    }
}
