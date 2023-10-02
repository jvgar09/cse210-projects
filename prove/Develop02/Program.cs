using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }
}

class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response, string date)
    {
        entries.Add(new Entry { Prompt = prompt, Response = response, Date = date });
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved to file.");
    }

    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            entries.Clear(); // Clear existing entries before loading
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        entries.Add(new Entry { Date = parts[0], Prompt = parts[1], Response = parts[2] });
                    }
                }
            }
            Console.WriteLine("Journal loaded from file.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

class Program
{
    static void Main()
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Save ");
            Console.WriteLine("4. Load ");
            Console.WriteLine("5. Exit ");
            Console.Write("Enter your choice: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter response: ");
                        string response = Console.ReadLine();
                        Console.Write("Enter date: ");
                        string date = Console.ReadLine();
                        // Generate a random prompt from your list
                        string[] prompts = { "Prompt 1", "Prompt 2", "Prompt 3", "Prompt 4", "Prompt 5" };
                        Random rand = new Random();
                        string randomPrompt = prompts[rand.Next(prompts.Length)];
                        journal.AddEntry(randomPrompt, response, date);
                        break;
                    case 2:
                        journal.DisplayEntries();
                        break;
                    case 3:
                        Console.Write("Enter file name to save: ");
                        string saveFileName = Console.ReadLine();
                        journal.SaveToFile(saveFileName);
                        break;
                    case 4:
                        Console.Write("Enter file name to load: ");
                        string loadFileName = Console.ReadLine();
                        journal.LoadFromFile(loadFileName);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}

// Create a class that represents the structure of your CSV data
public class MyCsvData
{
    public string Column1 { get; set; }
    public string Column2 { get; set; }
   
}


// Read CSV data
var csvRecords = new List<MyCsvData>();
using (var reader = new StreamReader("promts.csv"))
using (var csv = new CsvReader(reader, new CsvConfiguration (CultureInfo.InvariantCulture)))
{
    csvRecords = csv.GetRecords<MyCsvData>().ToList();
}


// Read text from a .txt file
string filePath = "prompts.txt";
if (File.Exists(filePath))
{
    string text = File.ReadAllText(filePath);
    Console.WriteLine("Text from the file:");
    Console.WriteLine(text);
}
else
{
    Console.WriteLine("File not found.");
}

Console.ReadKey();