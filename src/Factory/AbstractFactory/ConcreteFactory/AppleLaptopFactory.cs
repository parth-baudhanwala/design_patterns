using Factory.AbstractFactory.AbstractFactory;
using Factory.AbstractFactory.AbstractProduct;
using Factory.AbstractFactory.ConcreteProduct;

namespace Factory.AbstractFactory.ConcreteFactory;

public class AppleLaptopFactory : IComputerFactory
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
        return new Laptop();
    }
}
