using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2022, 11, 03), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2022, 11, 04), 45, 15.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 05), 60, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
