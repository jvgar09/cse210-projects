using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a sample order
        Address customerAddress = new Address("123 Main St", "Houston", "TX", "USA");
        Customer customer = new Customer("Javier Garcia", customerAddress);
        Product product1 = new Product("Product A", 1, 10.99, 2);
        Product product2 = new Product("Product B", 2, 7.50, 3);

        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        // Display packing label and shipping label
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());
    }
}
