
// Base class for all goals
public abstract class Goal
{
    private string name;
    private int points;
    protected int completionCount;
    protected bool isCompleted;

    public string Name
    {
        get { return name; }
    }

    public int Points
    {
        get { return points; }
    }

    public bool IsCompleted
    {
        get { return isCompleted; }
    }

    protected Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
        completionCount = 0;
        isCompleted = false;
    }

    public abstract void RecordEvent();
    public abstract string GetProgress();
}

