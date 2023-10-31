class ListingActivity : MindfullActivity
{
    private string[] listPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration)
    {
        name = "Listing Activity";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n";
    }

    public void Execute()
    {
        string prompt = listPrompts[new Random().Next(listPrompts.Length)];
        Start();
        Console.WriteLine($"Prompt: {prompt}");
        Thread.Sleep(2000); // Pause for 2 seconds
        Console.WriteLine("Start listing items...");
        Console.Write("Hit enter when done listing...");
        int itemCounter = 0;
        while (itemCounter < duration)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrEmpty(item))
                break;
            itemCounter++;
        }
        Console.WriteLine($"Number of items listed: {itemCounter}");
        End();
    }
}

