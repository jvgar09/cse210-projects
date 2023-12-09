using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // add color to the text in the console
        Console.ForegroundColor = ConsoleColor.Green;

        // list of activities
        List<Activity> activities = new List<Activity>();

        // add the instance to list, new running instance, sets date, sets duration, and sets distance in miles
        activities.Add(new Running(new DateTime(2022, 11, 03), 30, 3.0));
        // add the instance to list, new cycling instance, sets date, sets duration, and sets speed m/h 
        activities.Add(new Cycling(new DateTime(2022, 11, 04), 45, 15.0));
        // add the instance to list, new cycling instance, sets date, sets duration, and sets number of laps 
        activities.Add(new Swimming(new DateTime(2022, 11, 05), 60, 20));


        // this loop prints a summary of each activity. it utilizes polymorphism to call the GetSummary() method based on the type of each activity.
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}
