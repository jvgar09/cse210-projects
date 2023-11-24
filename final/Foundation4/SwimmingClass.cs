class Swimming : Activity //inheritance 
{
    private int _laps; // attributes

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance() // behaviors/methods 
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _minutes * 60;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }
}