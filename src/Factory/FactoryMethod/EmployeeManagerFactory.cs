using Factory.Enum;
using Factory.Model;

namespace Factory.FactoryMethod;

public class EmployeeManagerFactory
{
    public BaseEmployeeFactory CreateFactory(Employee employee)
    {
        BaseEmployeeFactory baseEmployeeFactory = employee.Type switch
        {
            EmployeeType.Contract => new ContractEmployeeFactory(employee),
            EmployeeType.Permanent => new PermanentEmployeeFactory(employee),
            _ => throw new InvalidOperationException(),
        };
        return baseEmployeeFactory;
    }
}
