class Order // class object 
{
    // access modifier, data type, variable;
    private List<Product> products;
    private Customer customer;

    // Construoctor
    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.CalculatePrice();
        }

        // Add one-time shipping cost based on customer's location
        totalCost += customer.IsInUSA() ? 5 : 35;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += $"{product.Name} (ID: {product.ProductId})\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{customer.Name}\n{customer.GetAddressAsString()}";
    }
}
