class BreathingActivity : MindfullActivity
{
    public BreathingActivity(int duration) : base(duration)
    {
        name = "Breathing Activity";
        description = "This activity will help you relax by guiding you through deep breathing. Clear your mind and focus on your breathing.\n";
    }

    public void Execute()
    {
        Start();
        DateTime stop = DateTime.Now.AddSeconds(duration);
        while(DateTime.Now < stop)
        {
            Console.WriteLine("Breathe in... ");
            Timer(2); // Pause for 2 second
            Console.WriteLine("Breathe out... ");
            Timer(2); // Pause for 2 second
        }
        End();
    }
}
    
//Console.Write("Hit enter when done...");
//using System.ComponentModel;