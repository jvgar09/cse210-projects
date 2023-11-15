using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
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
            Console.WriteLine(" The types of goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goals");
            Console.WriteLine("3. Checklist Goals");
            Console.WriteLine("Which type of goal would you like to create? ");  
            }
            else if (option == "2")
            {               
            Console.WriteLine(" The goals are:");
            SimpleGoal Goal = new SimpleGoal;
            EternalGoal Goal = new EternalGoal;
            ChecklistGoal Goal = new ChecklistGoal;
            Goal.Execute();

            }
            else if (option == "3")
            {               
            Console.WriteLine("What is the filename for the goal file?");

            }
            else if (option == "4")
            {               
            Console.WriteLine(" Which goals would you like to Load:");
            }
            else if (option == "5")
            {               
            Console.WriteLine(" What goal did you accomplish?:"); 
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

