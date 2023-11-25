class Order // class object 
{
    // access modifier, data type, variable;
    private List<Product> _products;
    private Customer _customer;

    // Construoctor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.CalculatePrice();
        }

        // Add one-time shipping cost based on customer's location
        totalCost += _customer.IsInUSA() ? 5 : 35;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.Name} (ID: {product.ProductId})\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.Name}\n{_customer.GetAddressAsString()}";
    }
}
