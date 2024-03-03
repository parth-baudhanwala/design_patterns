using Factory.Manager;
using Factory.Model;

namespace Factory.FactoryMethod;

public class PermanentEmployeeFactory : BaseEmployeeFactory
{
    public PermanentEmployeeFactory(Employee employee) : base(employee)
    {
    }

    public override IEmployeeManager Create()
    {
        PermanentEmployeeManager permanentEmployeeManager = new();
        _employee.HouseAllowance = permanentEmployeeManager.GetHouseAllowance();
        return permanentEmployeeManager;
    }
}

