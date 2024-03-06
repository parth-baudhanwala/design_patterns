namespace ProtoType.Model;

public class Address
{
    public Address() { }

    public Address(string? city, string? state, string? country)
    {
        City = city;
        State = state;
        Country = country;
    }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }
}
