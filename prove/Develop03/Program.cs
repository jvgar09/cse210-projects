using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class Program
{
    public static void Main()
    {
        // Initialize your scripture object here with the reference and text
        var scripture = new Scripture("Proverbs 3:5-6", 
        "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        while (true)
        {
            scripture.Display();
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            var input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            if (!scripture.HideRandomWord())
            {
                Console.WriteLine("All words are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }
        }
    }
}