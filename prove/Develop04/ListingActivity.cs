class ListingActivity : MindfullActivity
{
    private string[] listPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override string GetActivityName()
    {
        return "Listing";
    }

    public override void Execute()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
        string prompt = listPrompts[new Random().Next(listPrompts.Length)];
        Console.WriteLine($"Prompt: {prompt}");
        Thread.Sleep(2000); // Pause for 2 seconds
        Console.WriteLine("Start listing items...");
        int itemCounter = 0;
        while (itemCounter < duration)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrEmpty(item))
                break;
            itemCounter++;
        }
        Console.WriteLine($"Number of items listed: {itemCounter}");
    }
}

