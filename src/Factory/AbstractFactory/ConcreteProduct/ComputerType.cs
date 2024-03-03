using Factory.AbstractFactory.AbstractProduct;
using Factory.Enum;

namespace Factory.AbstractFactory.ConcreteProduct;

public class Desktop : IComputerType
{
    public string GetComputerType()
    {
        return ComputerType.Desktop.ToString();
    }
}

public class Laptop : IComputerType
{
    public string GetComputerType()
    {
        return ComputerType.Laptop.ToString();
    }
}
