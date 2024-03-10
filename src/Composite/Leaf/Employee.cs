using Composite.Component;

namespace Composite.Leaf;

public class Employee : IEmployee
{
    public Employee(string name, string department)
    {
        Name = name;
        Department = department;
    }

    public string Name { get; set; }

    public string Department { get; set; }

    public void GetDetails(int indentation)
    {
        string space = new('\t', indentation);
        Console.WriteLine($"{space}Name: {Name}, Department: {Department} - Employee (Leaf)");
    }
}
