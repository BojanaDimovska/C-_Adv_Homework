using System;

namespace WorkingDays
{
    class Program
    {
        static void IsItAWorkingDay(int year, int month, int day)
        {
            DateTime startDate = new DateTime(1999, 1, 1);
            DateTime endDate = DateTime.Today;

            if (day > 0 || day < 31)
            {
                if (month > 1 || month < 12)
                {
                    DateTime date = new DateTime(year, month, day);
                    if (date <= endDate && date >= startDate)
                    {
                        if (day == 1 && month == 7 || day == 7 && month == 1 || day == 20 && month == 4 || day == 1 && month == 5 || day == 25 && month == 5 || day == 3 && month == 8 || day == 12 && month == 10 || day == 23 && month == 10 || day == 8 && month == 12)
                        {
                            Console.WriteLine("Not a working day.");
                        }
                        else if (date.DayOfWeek.ToString() == "Saturday" || date.DayOfWeek.ToString() == "Sunday")
                        {
                            Console.WriteLine("It's the WEEKEND.");
                        }
                        else
                        {
                            Console.WriteLine("It's a working day!");
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid year!");
                    }
                }
                else
                {
                    throw new Exception("Invalid month!");
                }
            }
            else
            {
                throw new Exception("Invalid day!");
            }
            
        }
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    int year, month, day;
                    Console.WriteLine("Enter day between 1-31:");
                    bool succDay = int.TryParse(Console.ReadLine(), out day);
                    Console.WriteLine("Enter month between 1-12:");
                    bool succMonth = int.TryParse(Console.ReadLine(), out month);
                    Console.WriteLine("Enter year between 1999 - 2021:");
                    bool succYear = int.TryParse(Console.ReadLine(), out year);
                    if (succDay && succMonth && succYear)
                    {
                        IsItAWorkingDay(year, month, day);
                    }
                    else
                    {
                        Console.WriteLine("Input can't be parsed!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Would you like to try again? yes/no");
                string choice = Console.ReadLine();
                if (choice == "yes")
                {
                    flag = true;
                    Console.Clear();
                }
                else
                {
                    flag = false;
                    Console.WriteLine("Thanks for stoping by. Have a good day!");
                }
            }
            Console.ReadLine();
        }
    }
}
