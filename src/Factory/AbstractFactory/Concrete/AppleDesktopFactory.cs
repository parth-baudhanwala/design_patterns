using Factory.AbstractFactory.Abstract;
using Factory.AbstractFactory.AbstractProduct;
using Factory.AbstractFactory.ConcreteProduct;

namespace Factory.AbstractFactory.Concrete;

public class AppleDesktopFactory : IComputerFactory
{
    public IComputerBrand GetComputerBrand()
    {
        return new Apple();
    }

    public IComputerProcessor GetComputerProcessor()
    {
        return new M2();
    }

    public IComputerType GetComputerType()
    {
        return new Desktop();
    }
}
