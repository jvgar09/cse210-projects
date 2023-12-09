// SwimmingClass derived (child) class
class Swimming : Activity //inheritance 
{
    private int _laps; // attributes, it represents the number of laps swum in the lap pool
    

    //constructor 
    public Swimming(DateTime date, int minutes, int laps): base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance() // behaviors/methods, it calculates and returns the distance covered during swimming  
    {
        // Distance (miles) = swimming laps * 50 / 1000 * 0.62
        return _laps * 50 / 1000 * 0.62;

    }

    public override double GetSpeed() // behaviors/methods, it calculates and returnst he speed in miles per hour
    {
        // Speed (mph or kph) = (distance / minutes) * 60
        return GetDistance() / _minutes * 60;
    }


    public override double GetPace() // behaviors/methods, it calculates and returns the pace in minutes per mile
    {
        // Pace = 60 / speed, Round to the nearest integer
        return (int)Math.Round(_minutes / GetDistance());
    }
}
