// Address class
class Address
{
    public string _Street { get; set; }
    public string _City { get; set; }
    public string _State { get; set; }
    public string _ZipCode { get; set; }

    public Address(string street, string city, string state, string zipCode)
    {
        _Street = street;
        _City = city;
        _State = state;
        _ZipCode = zipCode;
    }
}