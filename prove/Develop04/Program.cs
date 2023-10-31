using System;
using System.IO.Pipes;
using System.Threading; 

class Program
{
    static void Main(string[] args)
    {
        int duration;
        while (true)
        {
            Console.WriteLine("Mindfulness Activities Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity (1-4): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                duration = GetDuration();
                BreathingActivity activity = new BreathingActivity(duration);
                activity.Execute();
            }
            else if (choice == "2")
            {
                duration = GetDuration();
                ReflectionActivity activity = new ReflectionActivity(duration);
                activity.Execute();
            }
            else if (choice == "3")
            {
                duration = GetDuration();
                ListingActivity activity = new ListingActivity(duration);
                activity.Execute();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid activity.\n");
            }
        }
    }

    static int GetDuration()
    {
        int duration;
        do
        {
            Console.Write("Enter the duration (in seconds): \n");
            duration = int.Parse(Console.ReadLine());
            if(duration <= 0)
                Console.WriteLine("Invalid input. Please enter a valid duration.");
        }
        while(duration <= 0);
        return duration;
    }
}