
class Customer
{
    public string Name { get; }
    public Address Address { get; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool CanReturn()
    {
        return Address.IsInUSA();
    }

    public string GetFullAddress()
    {
        return Address.GetFullAddress();
    }
}