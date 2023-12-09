// Derived OutdoorGathering class, (child class)
class OutdoorGathering : Event // Inheritance
{
    private string _weatherStatement; // encapsulation 


    // constructors to initiate instances for the OutdoorGatheringClass.
    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weatherStatement)
        : base(title, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
    }

    public string GetFullDetailsOutdoorGathering()
    {
        return $"{GetFullDetails()}\nType of Event: Outdoor Gathering\nSpecific type of event: Outdoor Gathering to connect with the outdoors and other Programmers.\nWeather: {_weatherStatement}";//Full Details Outdoor Gathering:
    }

}
