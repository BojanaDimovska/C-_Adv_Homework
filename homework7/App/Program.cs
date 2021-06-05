using Domain.Classes;
using Domain.DataBase;
using System;

namespace App
{
    class Program
    {
            public static DataBase _database = new DataBase();
        public static void Data()
        {
            Console.WriteLine("Insert properties for the dog:");
            Console.WriteLine("Insert name:");
            string name = Console.ReadLine();
            Console.WriteLine("Insert color:");
            string color = Console.ReadLine();
            Console.WriteLine("Insert age:");
            bool ageValidation = int.TryParse(Console.ReadLine(), out int age);
            if (ageValidation)
            {
                Dog dog = new Dog(name, age, color);
                _database.Insert(dog);
            }
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Hi there!\nChoose one of the following options:");
            Console.WriteLine("1.) Insert a dog");
            Console.WriteLine("2.) List of the dogs");
            Console.WriteLine("3.) Exit");
        }
       
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                bool choiceValidation = int.TryParse(Console.ReadLine(), out int choice);
                if (choiceValidation)
                {
                    if (choice == 1)
                    {
                        Console.Clear();
                        Data();
                        Console.WriteLine("Press any key to continue.");
                        break;
                    }
                    else if (choice == 2)
                    {
                        Console.Clear();
                        _database.GetAll();
                        Console.WriteLine("Press any key to continue.");
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Goodbye!");
                        flag = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Try again, invalid input. Press any key to continue.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Menu();
                }
            }

            Console.ReadLine();
        }
    }
}
