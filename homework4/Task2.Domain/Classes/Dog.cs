using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Domain.Classes
{
    public class Dog : Pet
    {
        public string FavoriteFood { get; set; }

        public Dog (string favFood, string name, string type, int age) : base (name, type, age)
        {
            FavoriteFood = favFood;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is a dog, and it's favorite food is {FavoriteFood}.");
        }
    }
}
