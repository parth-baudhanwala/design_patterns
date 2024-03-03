﻿namespace Factory.Manager;

public class PermanentEmployeeManager : IEmployeeManager
{
    public decimal GetBonus()
    {
        return 10;
    }

    public decimal GetPay()
    {
        return 20;
    }

    public decimal GetHouseAllowance()
    {
        return 150;
    }
}
