using System.Runtime.InteropServices;
using System;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();

        int option = 0;
        Random rand = new Random();

        while (option != 5)
        {
            
            Console.WriteLine( "Please choose a number between 1 and 5.");
            Console.WriteLine("1. Write a new entry ");
            Console.WriteLine("2. Display the journal ");
            Console.WriteLine("3. Save the journal ");
            Console.WriteLine("4. Load the journal ");
            Console.WriteLine("5. Exit ");
            Console.Write("Enter your choice: ");
            option = int.Parse(Console.ReadLine());
            
  
            
            if (option == 1)
            {
                Entry entry = new Entry();
                PromptGenerator promptGenerator = new PromptGenerator();
                DateTime currentDate = DateTime.Now;

                entry._date = currentDate.ToShortDateString();
                entry._prompt = promptGenerator.Display();
                Console.WriteLine(entry._date);
                Console.WriteLine(entry._prompt);
                entry._answer = Console.ReadLine();
                journal._entries.Add(entry);
            }
            else if (option == 2)
            {
                journal.Display();
            }
            else if (option == 3)
            {
                Console.WriteLine("What is the name of the file that you will like to save?");
                journal._fileName = Console.ReadLine();
                journal.SaveFile();

            }
            else if (option == 4)
            {
                Console.WriteLine("What is the name of the file that you will like to load?");
                journal._fileName = Console.ReadLine();
                journal.LoadFile();
            }
            

        }


    }
    
}
