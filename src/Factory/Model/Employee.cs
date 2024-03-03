using Factory.Enum;

namespace Factory.Model;

public class Employee
{
    public Employee(string name, EmployeeType type)
    {
        Name = name;
        Type = type;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public EmployeeType Type { get; set; }
    public decimal HourlyPay { get; set; }
    public decimal Bonus { get; set; }
    public decimal HouseAllowance { get; set; }
    public decimal MedicalAllowance { get; set; }
    public string? ComputerDetails { get; set; }
}
