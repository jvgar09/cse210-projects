using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("1920 Grove Pl", "GroveCity", "MO", "12345");
        Address address2 = new Address("1847 Pioneer Ln", "Townsville", "UT", "67890");
        Address address3 = new Address("909 Pine St", "Villageton", "TX", "45678");

        Lecture lectureEvent = new Lecture("Amazing Lecture", "Learn something amazing", DateTime.Now.AddDays(7), "2:00 PM", address1, "John Doe", 100);
        Reception receptionEvent = new Reception("Networking Reception", "Meet and greet", DateTime.Now.AddDays(14), "6:00 PM", address2, "rsvp@example.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Nature Gathering", "Enjoy the outdoors", DateTime.Now.AddDays(21), "4:00 PM", address3, "The weather will be great!");

        Console.WriteLine("Standard Details:\n");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetStandardDetails());

        Console.WriteLine("\n\nFull Details:\n");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetFullDetails());

        Console.WriteLine("\n\nShort Description:\n");
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}
