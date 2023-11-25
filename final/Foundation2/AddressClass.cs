class Address // class object 
{
    // access modifier, data type, variable;
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Construoctor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA() 
    {
        // Returns true if the country is "USA", otherwise false
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}

