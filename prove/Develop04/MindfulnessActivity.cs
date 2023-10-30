
class MindfulnessActivity
{
    protected int duration;
    public ConsoleSpinner spinner;

    public MindfulnessActivity()
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
        Console.WriteLine($"Starting {GetActivityName()} activity...");
        Thread.Sleep(5000); // Pause for 5 seconds
    }

    public void End()
    {
        Console.WriteLine($"Great job! You've completed the {GetActivityName()} activity.\n");
        Console.WriteLine($"Total time: {duration} seconds");
        Thread.Sleep(5000); // Pause for 5 seconds
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
