using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task2.Domain.Classes;

namespace Task2.Domain
{
    public static class PetStoreDb<T> where T : Pet
    {
        public static List<T> Pets { get; set; }
        static PetStoreDb()
        {
            Pets = new List<T>();
        }

        public static void PrintPets()
        {
            foreach(T pet in Pets)
            {
                pet.PrintInfo();
            }
        }

        public static void BuyPet(string name)
        {
            T pets = Pets.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
            if(pets == null)
            {
                Console.WriteLine("Can't find pet by that name!");
                return;
            }
            Pets.Remove(pets);
            Console.WriteLine($"Thanks for purchasing {pets.Name}");
        }

    }
}
