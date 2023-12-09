using System;

// entry point of the program
class Program
{
    static void Main()
    {

        // set color to the text in console
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        // creating instances of the Address class
        Address address1 = new Address("1920 Grove Pl", "GroveCity", "NY", "12345");
        Address address2 = new Address("1847 Pioneer Ln", "Pionneerville", "UT", "67890");
        Address address3 = new Address("909 Pine Cir", "Villagtown", "TX", "45678");

        // creating instances of the derived classes (Lecture, Reception, OutdoorGathering)
        Lecture lectureEvent = new Lecture("Lecture on Programming with C# Lenguage", "Learn to program with classes", DateTime.Now.AddDays(7), "8:00 AM", address1, "Julio Keys", 185);
        Reception receptionEvent = new Reception("Networking Event", "Mingle with other Programmers", DateTime.Now.AddDays(14), "6:00 PM", address2, "rsvp@networking.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Connect with the outdoors and other Programmers", "Enjoing the outdoors with hot chocolate and S'mores", DateTime.Now.AddDays(21), "6:30 PM", address3, "The weather will be Mostly Clear!");


        // displaying standard details for each event
        Console.WriteLine("Standard Details:\n");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetStandardDetails());

        // displaying full details for each event
        Console.WriteLine("\n\nFull Details:\n");
        Console.WriteLine(lectureEvent.GetFullDetailsLecture());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetFullDetailsReception());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetFullDetailsOutdoorGathering());

        // displaying short descriptions for each event
        Console.WriteLine("\n\nShort Description:\n");
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetShortDescription());

    }
}
