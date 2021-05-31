using System;
using Task2.Domain;
using Task2.Domain.Classes;

namespace Task2.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Meat", "Otto", "Dog", 3);
            Dog dog2 = new Dog("Bread", "Sky", "Dog", 1);

            Cat cat = new Cat(true, 9, "Luna", "Cat", 1);
            Cat cat2 = new Cat(false, 7, "T'Challa", "Cat", 3);

            Fish fish = new Fish("Golden", "medium", "Pece", "Fish", 2);
            Fish fish2 = new Fish("Blue", "small", "Dori", "Fish", 4);

            PetStoreDb<Dog>.Pets.Add(dog);
            PetStoreDb<Dog>.Pets.Add(dog2);
            PetStoreDb<Cat>.Pets.Add(cat);
            PetStoreDb<Cat>.Pets.Add(cat2);
            PetStoreDb<Fish>.Pets.Add(fish);
            PetStoreDb<Fish>.Pets.Add(fish2);

            Console.WriteLine("Available pets:");
            PetStoreDb<Dog>.PrintPets();
            PetStoreDb<Cat>.PrintPets();
            PetStoreDb<Fish>.PrintPets();

            PetStoreDb<Dog>.BuyPet("Otto");
            PetStoreDb<Cat>.BuyPet("T'Challa");
            PetStoreDb<Fish>.BuyPet("Pece");

            Console.WriteLine("Available pets:");
            PetStoreDb<Dog>.PrintPets();
            PetStoreDb<Cat>.PrintPets();
            PetStoreDb<Fish>.PrintPets();



            Console.ReadLine();
        }
    }
}
