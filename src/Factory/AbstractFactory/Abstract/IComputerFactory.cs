using Factory.AbstractFactory.AbstractProduct;

namespace Factory.AbstractFactory.Abstract;

public interface IComputerFactory
{
    IComputerBrand GetComputerBrand();

    IComputerProcessor GetComputerProcessor();

    IComputerType GetComputerType();
}
