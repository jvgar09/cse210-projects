// User class to manage goals and score
public class User
{
    private List<Goal> goals;
    private int score;

    public User()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(Goal goal)
    {
        goal.RecordEvent();
        score += goal.Points;
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine($"{goal.GetProgress()} {goal.Name} - {goal.Points} points");
        }

        Console.WriteLine($"Total Score: {score} points");
    }
}
