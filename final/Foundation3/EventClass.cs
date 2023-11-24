// Base Event class
class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address.Street}, {_address.City}, {_address.State} {_address.ZipCode}";
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Generic Event";
    }

    public string GetShortDescription()
    {
        return $"Type: Generic Event\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}