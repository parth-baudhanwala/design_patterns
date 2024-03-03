using Factory.AbstractFactory.AbstractFactory;
using Factory.AbstractFactory.AbstractProduct;
using Factory.AbstractFactory.ConcreteProduct;

namespace Factory.AbstractFactory.ConcreteFactory;

public class DellDesktopFactory : IComputerFactory
{
    public IComputerBrand GetComputerBrand()
    {
        return new Dell();
    }

    public IComputerProcessor GetComputerProcessor()
    {
        return new I3();
    }

    public IComputerType GetComputerType()
    {
        return new Desktop();
    }
}
