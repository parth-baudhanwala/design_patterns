using Composite.Component;

namespace Composite;

public class Manager : IEmployee
{
    public List<IEmployee> subOrdinates;

    public Manager(string name, string department)
    {
        Name = name;
        Department = department;
        subOrdinates = new();
    }

    public string Name { get; set; }

    public string Department { get; set; }

    public void GetDetails(int indentation)
    {
        string space = new('\t', indentation);
        Console.WriteLine($"{space}Name: {Name}, Department: {Department} - Manager (Composite)");

        foreach (IEmployee employee in subOrdinates)
        {
            employee.GetDetails(indentation + 1);
        }
    }
}
