using App.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain
{
    public static class Validator
    {
        public static bool Validate(Vehicle vehicle)
        {
           if(vehicle.Id > 0 && !string.IsNullOrEmpty(vehicle.Type) && vehicle.YearOfProduction > 0)
            {
                return true;
            }
           else
            {
                return false;
                Console.WriteLine("Error!");
            }
        }
    }
}
