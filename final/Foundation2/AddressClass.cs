class Address // class object 
{
    // access modifier, data type, variable;
    private string street;
    private string city;
    private string state;
    private string country;

    // Construoctor
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public bool IsInUSA() 
    {
        // Returns true if the country is "USA", otherwise false
        return country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString()
    {
        return $"{street}, {city}, {state}, {country}";
    }
}

