// Derived Reception class, (child class)
class Reception : Event // Inheritance
{
    private string _rsvpEmail; // encapsulation 

    // constructor to initiate instances for the ReceptionClass
    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetFullDetailsReception()
    {
        return $"{GetFullDetails()}\nType of Event: Reception\nSpecific type of event: A reception to network.\nRSVP to: {_rsvpEmail}";
    }
}
