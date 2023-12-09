using System;

// Base Event class, (parent class)
class Event
{
    // the attributes are encapsulated
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _address;

    // constructors to initiate the instances for the EventClass
    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    // behavior/methods
    public string GetStandardDetails()
    {
        return $"Event Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address._Street}, {_address._City}, {_address._State} {_address._ZipCode}";
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}";
    }

    public string GetShortDescription()
    {
        return $"Event Type: {_description}\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}
