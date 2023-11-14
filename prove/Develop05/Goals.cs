
// Base class for all goals
public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; protected set; }
    public bool IsCompleted { get; protected set; }

    public abstract void RecordEvent();
    public abstract string GetProgress();
}




