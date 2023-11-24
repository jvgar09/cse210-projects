class Cycling : Activity  //inheritance 
{
    private double _speed; // attribute 

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed() //behavors/methods 
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}
