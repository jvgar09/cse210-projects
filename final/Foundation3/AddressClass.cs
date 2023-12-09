// Address class with the address details
class Address
{
    // getters and setters 
    public string _Street { get; set; }
    public string _City { get; set; }
    public string _State { get; set; }
    public string _ZipCode { get; set; }

    // constructors to initiate the instances for the AddressClass
    public Address(string street, string city, string state, string zipCode)
    {
        _Street = street;
        _City = city;
        _State = state;
        _ZipCode = zipCode;
    }
}
