using Factory.AbstractFactory.AbstractFactory;
using Factory.Enum;
using Factory.Model;

namespace Factory.AbstractFactory.ConcreteFactory;

public class EmployeeComputerFactory
{
    public IComputerFactory Create(Employee employee)
    {
        IComputerFactory computerFactory = employee.Type switch
        {
            EmployeeType.Contract => new DellLaptopFactory(),
            EmployeeType.Permanent => new AppleLaptopFactory(),
            _ => throw new InvalidOperationException(),
        };
        return computerFactory;
    }
}
