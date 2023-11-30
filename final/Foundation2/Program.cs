using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        // giving color to the display info. 
        Console.ForegroundColor = ConsoleColor.Green; 

        // Create addresses
        Address usaAddress = new Address("123 Main St", "Anytown", "X", "USA");
        Address nonUsaAddress = new Address("456 Oak St", "Othercity", "NL", "Mexico");

        // Create customers
        Customer customer1 = new Customer("John Doe", usaAddress);
        Customer customer2 = new Customer("Juana Lucas", nonUsaAddress);

        // Create products
        Product product1 = new Product("Product A", 1, 10.99, 2);
        Product product2 = new Product("Product B", 2, 7.50, 3);
        Product product3 = new Product("Product C", 3, 5.99, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display results
        DisplayOrderDetails(order1);
        Console.WriteLine("-----------------------");
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order.CalculateTotalCost():F2}\n");
    }
}

