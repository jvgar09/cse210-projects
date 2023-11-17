using System;

// Simple goal class - derivrf/ sub class
public class SimpleGoal : Goal //ineritence 
{   //constroctors 
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }
    public SimpleGoal(string name, string description, int points, bool isCompleted) : base(name, description, points, isCompleted) { }

    public override int RecordEvent() //polmorphism 
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            Console.WriteLine($"Congratulations! You completed the {Name} goal and earned {Points} points.");
            return _points;
        }
        else
        {
            Console.WriteLine($"You've already completed the {Name} goal.");
            return 0;
        }
    }

    public override string GetSaveString()  //polmorphism 
    {
        return $"{base.GetSaveString()}|{_isCompleted}";
    }


}

