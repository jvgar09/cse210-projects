
class MindfullActivity
{
    protected int duration;
    public ConsoleSpinner spinner;

    public MindfullActivity()
    {
        duration = 0;
        spinner = new ConsoleSpinner();
    }

    public void SetDuration(int seconds)
    {
        duration = seconds;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {GetActivityName()} activity...\n");
        Thread.Sleep(2000); // Pause for 2 seconds
    }

    public void End()
    {
        Console.WriteLine($"Great job! You've completed the {GetActivityName()} activity.\n");
        Console.WriteLine($"Total time: {duration} seconds");
        Thread.Sleep(2000); // Pause for 2 seconds
    }

    public virtual string GetActivityName()
    {
        return "Mindfulness";
    }

    public void Run()
    {
        Start();
        Execute();
        End();
    }

    public virtual void Execute()
    {
        // Common execution logic
    }
}
