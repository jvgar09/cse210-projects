class Running : Activity  //inheritance 
{
    private double _distance; // attribute

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() // behaviors/methods 
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _minutes * 60;
    }

    public override double GetPace()
    {
        return _minutes / _distance;
    }
}