// RunningClass derived (child) class
class Running : Activity  //inheritance 
{
    private double _distance; // attribute


    //constructor 
    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;

    }

    public override double GetDistance() // behaviors/methods, it calculates and returns the distance covered during running
    {
        return _distance;
    }

    public override double GetSpeed() // behaviors/methods, it calculates and returns the speed in miles per hour
    {
        return _distance / _minutes * 60;

    }


    public override double GetPace() // behaviors/methods, it calculates and returns the pace in minutes per mile
    {
        return _minutes / _distance;
    }
}
