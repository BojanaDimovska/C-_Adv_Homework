using App.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Classes
{
    public class Cat : Animal, ICat
    {
        public Cat(string name, string race, int age) : base(name, race, age) { }
        public string Eat(string food)
        {
            return $"{Name} is eating {food}";
        }
    }
}
