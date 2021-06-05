using Bonus.Classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per1 = new Person ("Paul", "Paulsky", 20);
            Person per2 = new Person("Bob", "Bobsky", 30);
            Person per3 = new Person("Bojana", "Dimovska", 23);
            Person per4 = new Person("Boris", "Karakolev", 23);

            List<Person> people = new List<Person>()
            {
                per1,
                per2,
                per3,
                per4
            };

            string appPath = @"..\..\..\People";
            string filePath = appPath + @"\people.txt";

            if (!Directory.Exists(appPath))
            {
                Directory.CreateDirectory(appPath);
            }
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                string allPeople = "";
                for (int i = 0; i < people.Count; i++)
                {
                    if (i == people.Count - 1)
                    {
                        allPeople += $"{people[i].FirstName} {people[i].LastName} {people[i].Age}";
                    }
                    else
                    {
                        allPeople += $"{people[i].FirstName} {people[i].LastName} {people[i].Age}\n";
                    }
                }
                streamWriter.WriteLine(allPeople);
            }

            List<Person> newPeople = new List<Person>();

            using (StreamReader streamReader = new StreamReader(filePath))
            {
                for (int i = 0; i < people.Count; i++)
                {
                    string person = streamReader.ReadLine();
                    string[] info = person.Split(" ");
                    Person newPerson = new Person(info[0], info[1], Convert.ToInt32(info[2]));
                    newPeople.Add(newPerson);
                }
            }

            foreach (Person person in newPeople)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age}");
            }

            Console.ReadLine();
        }
    }
}
