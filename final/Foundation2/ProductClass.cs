class Product // class object 
{
    // access modifier, data type, variable;
    private string _name;
    private int _productId;
    private double _price; //floating-point data type (used for storing values such as prices, percentages, or any numeric value requiring decimal precision)
    private int _quantity;

    // Construoctor
    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double CalculatePrice() //double is a data type that represents a floating-point number
    {
        return _price * _quantity;
    }

    public string Name { get { return _name; } }
    public int ProductId { get { return _productId; } }
}
