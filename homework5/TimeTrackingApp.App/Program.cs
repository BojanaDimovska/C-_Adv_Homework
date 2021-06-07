using System;
using TimeTrackingApp.Domain.Classes;
using TimeTrackingApp.Services.Implementations;
using TimeTrackingApp.Services.Interfaces;

namespace TimeTrackingApp.App
{
    class Program
    {
        public static void LandingPage()
        {
            Console.Clear();
            Console.WriteLine("Time Tracking App\n\n");

            Console.WriteLine("Please choose one of the following options:\n");
            Console.WriteLine("1.) Log in\n2.) Register\n3.) Exit");
            bool flag = true;
            while (flag)
            {
                bool validationLandingPageChoice = int.TryParse(Console.ReadLine(), out int landingPageChoice);
                if (validationLandingPageChoice)
                {
                    if (landingPageChoice == 1)
                    {
                        if (_userService.LogIn() < 1)
                        {
                            LandingPage();
                        }
                        else
                        {
                            LandingPage();
                            flag = false;
                        }
                    }
                    else if (landingPageChoice == 2)
                    {
                        _userService.Register();
                        Console.ReadKey();
                        LandingPage();
                        flag = false;
                    }
                    else if (landingPageChoice == 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error bad input !\nTry Again.");
                    }
                }
                else
                {
                    Console.WriteLine("Error bad input !\nTry Again.");
                }
            }
        }
        public static IUserService<User> _userService = new UserService<User>();
        static void Main(string[] args)
        {
            LandingPage();
        }
    }
}
