class Order
{
    private List<Product> products = new List<Product>();
    public Customer Customer { get; }

    public Order(Customer customer)
    {
        Customer = customer;
    }

    // Add Product to the Order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Calculate the total price of order
    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var product in products)
        {
            totalPrice += product.CalculateTotalCost();
        }

        // Add the shipping cost
        if (Customer.Address.IsInUSA())
            totalPrice += 5m;
        else
            totalPrice += 35m;

        return totalPrice;
    }


    public string GeneratePackingLabel()
    {
        string packingLabel = $"Customer Name: {Customer.Name}\n\n";
        foreach (var product in products)
        {
            packingLabel += $"Product Name: {product.Name}, Product ID: {product.Id}\n";
        }
        return packingLabel;
    }


    public string GenerateShippingLabel()
    {
        return Customer.GetFullAddress();
    }
}
