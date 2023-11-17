using System;
//using System.Runtime.CompilerServices;
//using System.Security.Authentication.ExtendedProtection;
//using System.Threading.Channels;

// Base class for all goals
public abstract class Goal
{
    protected string _name;
    protected string _description; 
    protected int _points;
    protected bool _isCompleted;

    public string Name
    {
        get { return _name; }
    }

    public string Description
    {
        get { return _description; }
    }

    public int Points
    {
        get { return _points; }
    }

    public bool IsCompleted
    {
        get { return _isCompleted; }
    }

    protected Goal(string name, string description, int points)
    {
        _name = name;
        _description = description; 
        _points = points;
        _isCompleted = false;
    }

    protected Goal(string name, string description, int points, bool isCompleted)
    {
        _name = name;
        _description = description; 
        _points = points;
        _isCompleted = isCompleted;
    }

    protected char GetIsCompletedChar()
    {
        return _isCompleted ? 'X' : ' ';
    }

    //Abstract Methods of Goal
    public abstract int RecordEvent();
    public virtual string Display()
    {
        return $"[{GetIsCompletedChar()}] {_name} - {_description}";
    }
    public virtual string GetSaveString()
    {
        return $"{GetType()}|{_name}|{_description}|{_points}";
    }

}

