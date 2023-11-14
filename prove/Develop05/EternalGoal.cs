// Eternal goal class
public class EternalGoal : Goal
{
    public EternalGoal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You recorded an event for the eternal goal {Name} and earned {Points} points.");
    }

    public override string GetProgress()
    {
        return "[Eternal]";
    }
}