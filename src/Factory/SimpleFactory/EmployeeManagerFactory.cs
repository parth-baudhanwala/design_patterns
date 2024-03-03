using Factory.Enum;
using Factory.Manager;

namespace Factory.SimpleFactory;

public class EmployeeManagerFactory
{
    public IEmployeeManager GetEmployeeManager(EmployeeType employeeType)
    {
        IEmployeeManager employeeManager = employeeType switch
        {
            EmployeeType.Contract => new ContractEmployeeManager(),
            EmployeeType.Permanent => new PermanentEmployeeManager(),
            _ => throw new InvalidOperationException(),
        };
        return employeeManager;
    }
}

