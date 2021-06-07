using System;
using System.Linq;
using TimeTrackingApp.Domain.Classes;

namespace TimeTrackingApp.Services.Helpers
{
    public static class ValidationHelper
    {
        public static bool ValidateUsername(User user)
        {

            if (user.Username.Length < 5)
            {
                Console.WriteLine("The username can't be less than 5 characters.");
                return false;
            }
            else
            {
                Console.WriteLine("Username approved !");
                return true;
            }
        }
        public static bool ValidatePassword(User user)
        {
            if (user.Password.Length < 5)
            {
                Console.WriteLine("The password can't be less than 6 characters.");
                return false;
            }
            else
            {
                if (user.Password.Any(char.IsUpper) && user.Password.Any(char.IsDigit))
                {
                    Console.WriteLine("Password approved.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Password must contain at least one capital letter and at least one number.");
                    return false;
                }
            }
        }
        public static bool ValidateFirstNameLastName(User user)
        {
            if (user.FirstName.Length < 2 && user.LastName.Length < 2)
            {
                Console.WriteLine("First and Last name can not be shorter than 2 characters.");
                return false;
            }
            else
            {
                bool firstNameContainsNumber = user.FirstName.Any(char.IsDigit);
                bool lastNameContainsNumber = user.LastName.Any(char.IsDigit);
                bool firstNameContainsSymbol = user.FirstName.Any(char.IsSymbol);
                bool lastNameContainsSymbol = user.LastName.Any(char.IsSymbol);
                if (firstNameContainsNumber || lastNameContainsNumber || lastNameContainsSymbol || firstNameContainsSymbol)
                {
                    Console.WriteLine("First and Last name must not contain numbers or symbols.");
                    return false;
                }
                else
                {
                    Console.WriteLine("First and last name approved !");
                    return true;
                }
            }
        }
        public static bool ValidateAge(User user)
        {
            {
                if (user.Age < 18 || user.Age > 120)
                {
                    Console.WriteLine("Age must be between 18 to 120.");
                    return false;
                }
                else
                {
                    Console.WriteLine("Age approved !");
                    return true;
                }

            }

        }
    }
}
