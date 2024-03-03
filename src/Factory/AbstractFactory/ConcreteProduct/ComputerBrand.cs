using Factory.AbstractFactory.AbstractProduct;
using Factory.Enum;

namespace Factory.AbstractFactory.ConcreteProduct;

public class Apple : IComputerBrand
{
    public string GetComputerBrand()
    {
        return ComputerBrand.Apple.ToString();
    }
}

public class Dell : IComputerBrand
{
    public string GetComputerBrand()
    {
        return ComputerBrand.Dell.ToString();
    }
}
