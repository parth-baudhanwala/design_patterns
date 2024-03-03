using Factory.AbstractFactory.AbstractProduct;

namespace Factory.AbstractFactory.AbstractFactory;

public interface IComputerFactory
{
    IComputerBrand GetComputerBrand();

    IComputerProcessor GetComputerProcessor();

    IComputerType GetComputerType();
}
