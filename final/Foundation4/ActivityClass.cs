class Activity
{
    private DateTime _date; // attributes 
    protected int _minutes; 

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double GetDistance() // behaviors/methods 
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary() // this method uses the overridden methods to gather specific details for each activity type, demonstrating the use of method overriding and polymorphism.
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}


