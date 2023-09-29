using System;

class Program
{
    static void Main(string[] args)
       {
        // Display the welcome message
        Console.WriteLine("Welcome to the Journal Program! ");

        // Display the prompt for user choice
        Console.WriteLine("Please select one of the following choices: ");

        // Your program choices can go here   

        // Display a prompt to the user
        Console.Write("");


   
        // Read the user's input
        string userInput = Console.ReadLine();

        // Display a message using the user's input
        Console.WriteLine($" {userInput}!");

        // Wait for the user to press a key before exiting
        Console.ReadKey();
    }
}

