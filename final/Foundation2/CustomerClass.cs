class Customer // class object 
{
    // access modifier, data type, variable;
    private string name;
    private Address address;

    // Construoctor
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsInUSA()  // Calls the IsInUSA method of the associated address
    {
        return address.IsInUSA();
    }

    public string Name { get { return name; } }

    public string GetAddressAsString()
    {
        return address.ToString();
    }
}