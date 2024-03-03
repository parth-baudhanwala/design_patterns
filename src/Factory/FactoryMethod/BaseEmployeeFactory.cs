using Factory.Manager;
using Factory.Model;

namespace Factory.FactoryMethod;

public abstract class BaseEmployeeFactory
{
    protected Employee _employee;

    public BaseEmployeeFactory(Employee employee)
    {
        _employee = employee;
    }

    public abstract IEmployeeManager Create();

    public void ApplySalary()
    {
        IEmployeeManager manager = Create();
        _employee.HourlyPay = manager.GetPay();
        _employee.Bonus = manager.GetBonus();
    }
}
