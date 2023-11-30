
class Customer // class object 
{
    // access modifier, data type, variable;
    private string _name;
    private Address _address;

    // Construoctor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUSA()  // Calls the IsInUSA method of the associated address
    {
        return _address.IsInUSA();
    }

    public string Name { get { return _name; } }

    public string GetAddressAsString()
    {
        return _address.ToString();
    }
}
