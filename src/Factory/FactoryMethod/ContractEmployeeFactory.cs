using Factory.Manager;
using Factory.Model;

namespace Factory.FactoryMethod;

public class ContractEmployeeFactory : BaseEmployeeFactory
{
    public ContractEmployeeFactory(Employee employee) : base(employee)
    {
    }

    public override IEmployeeManager Create()
    {
        ContractEmployeeManager contractEmployeeManager = new();
        _employee.MedicalAllowance = contractEmployeeManager.GetMedicalAllowance();
        return contractEmployeeManager;
    }
}

