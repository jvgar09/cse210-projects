
// Checklist goal class
public class ChecklistGoal : Goal
{
    private int completionTarget;

    public ChecklistGoal(string name, int points, int target) : base(name, points)
    {
        completionTarget = target;
    }

    public override void RecordEvent()
    {
        completionCount++;
        Console.WriteLine($"You recorded an event for the checklist goal {Name} and earned {Points} points.");

        if (completionCount == completionTarget)
        {
            isCompleted = true;
            Console.WriteLine($"Congratulations! You completed the checklist goal {Name} and earned a bonus of {Points * 2} points.");
        }
    }

    public override string GetProgress()
    {
        return $"Completed {completionCount}/{completionTarget} times";
    }
}