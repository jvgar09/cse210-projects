// Simple goal class
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        if (!isCompleted)
        {
            isCompleted = true;
            Console.WriteLine($"Congratulations! You completed the {Name} goal and earned {Points} points.");
        }
        else
        {
            Console.WriteLine($"You've already completed the {Name} goal.");
        }
    }

    public override string GetProgress()
    {
        return isCompleted ? "[X]" : "[ ]";
    }
}

