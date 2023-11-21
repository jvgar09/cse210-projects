
// Checklist goal class
public class ChecklistGoal : Goal //ineritence 
{
    private int _completionTarget;
    private int _completionCount;
    private int _bonus;

    //constructor 
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _completionTarget = target;
        _completionCount = 0;
        _bonus = bonus;
    }
    public ChecklistGoal(string name, string description, int points, bool isCompleted, int count, int target, int bonus) : base(name, description, points, isCompleted)
    {
        _completionTarget = target;
        _completionCount = count;
        _bonus = bonus;
    }

    public override int RecordEvent() //polmorphism 
    {
        _completionCount++;

        if (!_isCompleted)
        {
            if (_completionCount == _completionTarget)
            {
                _isCompleted = true;
                Console.WriteLine($"Congratulations! You completed the checklist goal {_name} and earned a bonus of {_points + _bonus} points.");
                return _points + _bonus;
            }
            else
            {
                Console.WriteLine($"You recorded an event for the checklist goal {_name} and earned {_points} points.");
                return _points;
            }
        }
        else
        {
            Console.WriteLine("This goal has already been completed!");
            return 0;
        }
    }

    public override string Display() //polmorphism 
    {
        return $"{base.Display()}\n\tCompleted: [{_completionCount}/{_completionTarget}] times";
    }

    public override string GetSaveString()
    {
        return $"{base.GetSaveString()}|{_isCompleted}|{_completionCount}|{_completionTarget}|{_bonus}";
    }
}