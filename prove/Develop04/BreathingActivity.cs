
class BreathingActivity : MindfullActivity
{
    public override string GetActivityName()
    {
        return "Breathing";
    }

    public override void Execute()
    {
        Console.WriteLine("This activity will help you relax by guiding you through deep breathing. Clear your mind and focus on your breathing.\n");
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000); // Pause for 2 second
            Console.WriteLine("Breathe out...");
            Thread.Sleep(2000); // Pause for 2 second
        }
    }
}
    
