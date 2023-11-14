// Simple goal class
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public override void RecordEvent()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            Console.WriteLine($"Congratulations! You completed the {Name} goal and earned {Points} points.");
        }
        else
        {
            Console.WriteLine($"You've already completed the {Name} goal.");
        }
    }

    public override string GetProgress()
    {
        return IsCompleted ? "[X]" : "[ ]";
    }
}