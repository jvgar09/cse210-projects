using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


public class Program
{
    public static void Main()
    {
        Random rnd = new();
        Dictionary<int, Dictionary<string, string>> scriptures = new()
        {
            {1, new Dictionary<string, string> {
                {"Text", "Therefore go, my son, and thou shalt be favored of the Lord, because thou hast anot bmurmured. And it came to pass that I, Nephi, said unto my father: I will go and do the things which  the Lord hath commanded, for I know that the Lord giveth no commandments unto  the children of men,  save he shall prepare a way for them that they may accomplish the thing which he commandeth them."},
                {"Reference", "1 Nephi 3:6-7"}}},
            {2, new Dictionary<string, string> {
                {"Text", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."},
                {"Reference", "Proverbs 3:5-6"}}}
        };
       
        int key = 1;//rnd.Next(1, scriptures.Count);
        Scripture scripture = new Scripture(scriptures[key]["Reference"],       
        scriptures[key]["Text"]);

        while (true)
        {
            scripture.Display();
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

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