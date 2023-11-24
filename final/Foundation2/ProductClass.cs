class Product // class object 
{
    // access modifier, data type, variable;
    private string name;
    private int productId;
    private double price; //floating-point data type (used for storing values such as prices, percentages, or any numeric value requiring decimal precision.)
    private int quantity;

    // Construoctor
    public Product(string name, int productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public double CalculatePrice() //double is a data type that represents a floating-point number
    {
        return price * quantity;
    }

    public string Name { get { return name; } }
    public int ProductId { get { return productId; } }
}
