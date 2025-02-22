﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TimeTrackingApp.Domain.Enums;

namespace TimeTrackingApp.Domain.Classes
{
    public class OtherHobbies
    {
        public string Title { get; set; }
        public ActivityType Type { get; set; }

        public OtherHobbies()
        {
            Title = "Other hobbies";
            Type = ActivityType.OtherHobbies;
        }
        public void HobbiesStopwatch(User user)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Press ENTER to stop.");
            string stop = Console.ReadLine();
            if (stop == "")
            {
                stopwatch.Stop();
                TimeSpan time = stopwatch.Elapsed;
                double convertedTime = Convert.ToDouble(time.TotalSeconds);
                user.TimeOtherHobbies += convertedTime / 60;
                Console.WriteLine($"Time spent on {Title}: {Math.Round(convertedTime / 60, 2)} minutes.");
                Console.WriteLine("Press any key to go back to the Main Menu.");
                Console.ReadKey();
            }
        }
        public void OtherHobiesActivity(User user)
        {
            List<string> hobbies = new List<string>();
            bool hobbiesFlag = true;
            while (hobbiesFlag)
            {
                Console.Clear();
                Console.WriteLine("Enter a hobby:");
                Console.WriteLine("If you have no hobbies left to enter, press ENTER.");
                string hobbie = Console.ReadLine();
                if (hobbie == "")
                {
                    hobbiesFlag = false;
                }
                hobbies.Add(hobbie);
            }
            List<string> hobbiesDistinct = hobbies.Distinct().ToList();
            user.Hobbies = hobbiesDistinct;
            Console.WriteLine("Doing some other hobbies...");
            HobbiesStopwatch(user);
        }
    }
}
