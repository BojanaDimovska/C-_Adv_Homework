using App.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain
{
    public static class VehicleDb
    {
        public static List<Vehicle> Vehicles { get; set; }

        static VehicleDb()
        {
            Vehicles = new List<Vehicle>()
            {
                new Car(60, new List<string>() {"Italy", "Germany", "America"}, 1, "Volkswagen", 2011, 5463),
                new Car(40, new List<string>() {"Macedonia", "Denmark", "Norway"}, 2, "Mercedes-Benz", 2018, 7439),
                new Car(15, new List<string>() {"Spain", "England", "Poland"}, 3, "Audi", 2020, 3234),
                new Bike("Black", 4, "Yamaha", 2021, 5748),
                new Bike("Green", 5, "Suzuki", 2015, 4393),
                new Bike("Red", 6, "Aprilia", 2005, 9823),
                new Vehicle(7, "Truck", 2006, 3984),
                new Vehicle(7, "Airplane", 2007, 3983),
                new Vehicle(7, "Boat", 2008, 3084),
            };
        }
    }
}
