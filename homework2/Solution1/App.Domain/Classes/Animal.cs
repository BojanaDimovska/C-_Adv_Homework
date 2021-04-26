using App.Domain.Interfaces;
using System;

namespace App.Domain.Classes
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public int Age { get; set; }

        public Animal(string name, string race, int age)
        {
            Name = name;
            Race = race;
            Age = age;
        }
        public void PrintAnimal()
        {
            Console.WriteLine($"Name:{Name}, Race:{Race}, Age:{Age}");
        }
    }
}
