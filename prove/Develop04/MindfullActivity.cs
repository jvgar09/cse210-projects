class MindfullActivity
{
    protected int duration;
    protected string name;
    protected string description;
    private string[] symbols = {"=>   ", "==>  ", "===> ", "====>"};

    public MindfullActivity(int duration)
    {
        this.duration = duration;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {name}...\n");
        Console.WriteLine(description);
        Console.Write("\nGet Ready ");
        Spinner(5);
    }

    public void End()
    {
        Console.WriteLine($"Great job! You've completed the {name}.\n");
        Console.WriteLine($"Total time: {duration} seconds");
        Spinner(5);
    }

    public void Timer(int duration)
    {
        for(int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            
        }
    }

    public void Spinner(int duration)
    {
        for(int _ = duration; _ > 0; _--)
        {
            foreach(string frame in symbols)
            {
                Console.Write(frame);
                Thread.Sleep(250);
                for(int x = 5; x > 0; x--)
                {
                    Console.Write("\b \b");
                }
            }
        }
    }
}
