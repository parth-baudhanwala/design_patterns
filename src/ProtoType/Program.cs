using ProtoType.Model;

Console.WriteLine("\n<---------- Shallow Copy ---------->\n");

Copy(false);

Console.WriteLine("\n<---------- Deep Copy ---------->\n");

Copy(true);


static void Copy(bool useDeepClone)
{
    Citizen citizen1 = new()
    {
        Id = Guid.NewGuid(),
        FirstName = "Parth",
        LastName = "Baudhanwala",
        PassportNumber = 3,
        Address = new()
        {
            City = "Surat",
            State = "Gujarat",
            Country = "India"
        }
    };

    Console.WriteLine($"{citizen1.FirstName}: {citizen1.PassportNumber}, {citizen1.Address.City}, {citizen1.Address.State}, {citizen1.Address.Country}");

    Citizen citizen2 = (Citizen)(useDeepClone ? citizen1.DeepClone() : citizen1.Clone());
    citizen2.FirstName = "Hailee";
    citizen2.PassportNumber = 1;
    citizen2.Address!.City = "LA";
    citizen2.Address.State = "California";
    citizen2.Address.Country = "United States";

    Console.WriteLine($"{citizen2.FirstName}: {citizen2.PassportNumber}, {citizen2.Address.City}, {citizen2.Address.State}, {citizen2.Address.Country}");
    Console.WriteLine($"{citizen1.FirstName}: {citizen1.PassportNumber}, {citizen1.Address.City}, {citizen1.Address.State}, {citizen1.Address.Country}");
}
