namespace ProtoType.Model;

public partial class Citizen
{
    public Citizen() { }

    public Guid Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int PassportNumber { get; set; }

    public Address? Address { get; set; }
}

public partial class Citizen : ICloneable
{
    public Citizen(Guid id,
                   string? firstName,
                   string? lastName,
                   int passportNumber,
                   string? city,
                   string? state,
                   string? country)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        PassportNumber = passportNumber;
        Address = new Address(city, state, country);
    }

    public object Clone()
    {
        return MemberwiseClone();
    }

    public object DeepClone()
    {
        return new Citizen(Id,
                           FirstName,
                           LastName,
                           PassportNumber,
                           Address?.City,
                           Address?.State,
                           Address?.Country);
    }
}
