using App.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Classes
{
    public class Dog : Animal, IDog
    {
        public Dog (string name, string race, int age) : base(name, race, age) { }
       
        public void Bark()
        {
            Console.WriteLine($"{Name} says: Wuf, Wuf");
        }
    }
}
