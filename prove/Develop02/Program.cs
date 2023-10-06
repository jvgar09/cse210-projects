using System.Runtime.InteropServices;

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
            option = int.Parse(Console.ReadLine());
            if (option < 1 || option > 5)
            {
                Console.WriteLine{"Please choose a number between 1 and 5."};
            }
            else if (option == 1)
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