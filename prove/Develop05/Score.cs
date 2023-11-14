// User class to manage goals and score
public class User
{
    public List<Goal> Goals { get; private set; }
    public int Score { get; private set; }

    public User()
    {
        Goals = new List<Goal>();
        Score = 0;
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void RecordEvent(Goal goal)
    {
        goal.RecordEvent();
        Score += goal.Points;
    }

    public void DisplayGoals()
    {
        foreach (var goal in Goals)
        {
            Console.WriteLine($"{goal.GetProgress()} {goal.Name} - {goal.Points} points");
        }

        Console.WriteLine($"Total Score: {Score} points");
    }
}
