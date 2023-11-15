// Eternal goal class
public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        completionCount++;
        Console.WriteLine($"You recorded an event for the eternal goal {Name} and earned {Points} points.");
    }

    public override string GetProgress()
    {
        return $"Completed {completionCount} times";
    }
}
