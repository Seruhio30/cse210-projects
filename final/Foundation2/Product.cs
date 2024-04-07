class Product
{
    public string Name { get; }
    public string Id { get; }
    public decimal PricePerUnit { get; }
    public int Quantity { get; }

    public Product(string name, string id, decimal pricePerUnit, int quantity)
    {
        Name = name;
        Id = id;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
    }

    public decimal CalculateTotalCost()
    {
        return PricePerUnit * Quantity;
    }
}


