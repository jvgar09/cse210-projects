// Derived Lecture class, (child class)
class Lecture : Event // Inheritance
{
    // encapsulation
    private string _speaker;
    private int _capacity;

    // constructors to initiate the instances for the lecture class
    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetFullDetailsLecture()
    {
        return $"{GetFullDetails()}\nType of Event: Lecture\nSpecific type of event: Lecture on programming.\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
