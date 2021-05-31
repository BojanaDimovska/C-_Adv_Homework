using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Domain.Classes
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(bool lazy, int livesLeft, string name, string type, int age) : base (name, type, age)
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
        }

        public override void PrintInfo()
        {
            if(Lazy == true)
            {
                Console.WriteLine($"{Name} is a cat and has {LivesLeft} lives left. And is very lazy");
            }
            else
            {
                Console.WriteLine($"{Name} is a cat and has {LivesLeft} lives left. And is not lazy at all.");
            }
        }
    }
}
