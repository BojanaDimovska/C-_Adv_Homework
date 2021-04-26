using App.Domain.Classes;
using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Otto", "Golden Retriver", 3);
            Dog dog2 = new Dog("Sky", "American Bullie", 2);
            Cat cat1 = new Cat("T'Challa", "Bombay Cat", 3);
            Cat cat2 = new Cat("Luna", "Bengal Cat", 1);

            
            Console.WriteLine("Dogs:");
            dog1.PrintAnimal();
            dog1.Bark();
            dog2.PrintAnimal();
            dog2.Bark();

            Console.WriteLine("Cats:");
            cat1.PrintAnimal();
            Console.WriteLine(cat1.Eat("Fish"));
            cat2.PrintAnimal();
            Console.WriteLine(cat2.Eat("Meat"));

            List<Animal> animal = new List<Animal>
            {
                dog1,
                dog2,
                cat1,
                cat2
            };

            try
            {
                if(animal != null)
                {
                    foreach(Animal pet in animal)
                    {
                        if(pet.GetType() == dog1.GetType())
                        {
                            ((Dog)pet).Bark();
                        }
                        else if (pet.GetType() == cat1.GetType())
                        {
                            Console.WriteLine(((Cat)pet).Eat("fish"));
                        }
                        else
                        {
                            Console.WriteLine("There is no pets that is a dog or a cat.");
                        }
                    }
                }
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("Pet doesn't exist");
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
