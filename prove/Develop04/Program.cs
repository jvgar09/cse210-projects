using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
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
                MindfullActivity activity = new BreathingActivity();
                ActivityMenu(activity);
            }
            else if (choice == "2")
            {
                MindfullActivity activity = new ReflectionActivity();
                ActivityMenu(activity);
            }
            else if (choice == "3")
            {
                MindfullActivity activity = new ListingActivity();
                ActivityMenu(activity);
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

    static void ActivityMenu(MindfullActivity activity)
    {
        int duration;
        Console.Write("Enter the duration (in seconds): \n");
        if (int.TryParse(Console.ReadLine(), out duration))
        {
            activity.SetDuration(duration);
            activity.Run();
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid duration.");
        }
    }
}


class ConsoleSpinner
{
    private int counter;
    private string[] symbols = { "/", "-", "\\", "|" };
    private Timer timer;

    public void StartSpinner(int delay = 250)
    {
        timer = new Timer(UpdateSpinner, null, 0, delay);
    }

    public void StopSpinner()
    {
        timer.Change(Timeout.Infinite, Timeout.Infinite);
    }

    private void UpdateSpinner(object state)
    {
        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
        Console.Write(symbols[counter]);
        counter = (counter + 1) % symbols.Length;
    }
}

