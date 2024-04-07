class Program
{
    static void Main(string[] args)
    {
        // Create address
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Oak St", "Sometown", "NY", "Canada");
        Address address3 = new Address("742 Evergreen Terrace", "Springfield", "??", "USA");

        // Create Customer
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        Customer customer3 = new Customer("The Simpsons Family", address3);

        // Create Products
        Product product1 = new Product("Product 1", "P001", 10.50m, 2);
        Product product2 = new Product("Product 2", "P002", 5.25m, 3);
        Product product3 = new Product("Product 3", "P003", 8.75m, 1);

        // Create Order
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Order order3 = new Order(customer3);
        order3.AddProduct(product1);

        // Display packing labels, shipping labels, and total price for each order
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine($"Total Price: {order1.CalculateTotalPrice():C}");
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine($"Total Price: {order2.CalculateTotalPrice():C}");
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Order 3:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order3.GeneratePackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order3.GenerateShippingLabel());
        Console.WriteLine($"Total Price: {order3.CalculateTotalPrice():C}");
    }
}
