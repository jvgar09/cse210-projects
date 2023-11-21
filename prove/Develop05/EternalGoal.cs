// Eternal goal class - derived/sub class 
public class EternalGoal : Goal //ineritence 
{
    private int _completionCount;
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _completionCount = 0;
    }

    public EternalGoal(string name, string description, int points, int completionCount) : base(name, description, points)
    {
        _completionCount = completionCount;
    }

    public override int RecordEvent() //polmorphism 
    {
        _completionCount++;
        Console.WriteLine($"You recorded an event for the eternal goal {Name} and earned {Points} points.");
        return _points;
    }

    public override string Display() //polmorphism 
    {
        return $"{base.Display()}\n\tCompleted: {_completionCount} times";
    }
}
