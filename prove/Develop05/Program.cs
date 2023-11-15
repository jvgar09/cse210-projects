using System;
using System.Collections.Generic;

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
            Console.Write("Select a Choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {  
            Console.WriteLine(" The types of goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goals");
            Console.WriteLine("3. Checklist Goals");
            Console.WriteLine("Which type of goal would you like to create? ");
    
            }
            else if (choice == "2")
            {               
              
            }
            else if (choice == "3")
            {               
                
            }
            else if (choice == "4")
            {
            Console.WriteLine("Goodbye!");
            break;
            }
            else
            {
            Console.WriteLine("Invalid choice. Please select a valid option.\n");
            }
        }
    }
}

