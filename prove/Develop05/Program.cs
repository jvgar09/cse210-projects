using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        User user = new();
        while (true)
        {
            Console.WriteLine($"Total Score: {user.Score} points");
            Console.WriteLine(" Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an Option from the menu: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                user.AddGoal();
            }
            else if (option == "2")
            {
                user.DisplayGoals();
            }
            else if (option == "3")
            {
                Console.Write("What is the filename for the goal file?");
                string path = Console.ReadLine();
                user.Save(path);

            }
            else if (option == "4")
            {
                Console.Write("What is the filename for the goal file?");
                string path = Console.ReadLine();
                user.Load(path);
            }
            else if (option == "5")
            {
                user.RecordEvent();
            }
            else if (option == "6")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please select a valid option.\n");
            }
        }
    }
}

