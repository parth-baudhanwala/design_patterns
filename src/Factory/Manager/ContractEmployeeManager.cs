namespace Factory.Manager;

public class ContractEmployeeManager : IEmployeeManager
{
    public decimal GetBonus()
    {
        return 5;
    }

    public decimal GetPay()
    {
        return 10;
    }

    public decimal GetMedicalAllowance()
    {
        return 100;
    }
}
