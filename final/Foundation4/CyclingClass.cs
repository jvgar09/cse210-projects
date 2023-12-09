// CyclingClass derived (child) class
class Cycling : Activity  //inheritance 
{
    private double _speed;// attribute, it represents the speed during cycling

    //constructor 
    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()  //behavors/methods, it returns the speed in miles per hour 
    {
        // Pace (min per mile)= minutes / distance
        return _speed;
    }

    public override double GetPace()   //behavors/methods, it calculates and returns the pace in minutes per mile
    {
        // Pace = 60 / speed
        return 60 / _speed;
    }

}
