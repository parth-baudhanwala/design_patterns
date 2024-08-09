using Factory.AbstractFactory.Abstract;
using Factory.Enum;
using Factory.Model;

namespace Factory.AbstractFactory.Concrete;

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
