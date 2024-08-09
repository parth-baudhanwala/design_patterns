using Factory.AbstractFactory.Abstract;
using Factory.AbstractFactory.AbstractProduct;

namespace Factory.AbstractFactory.Client;

public class EmployeeComputerManager
{
    private readonly IComputerFactory _computerFactory;

    public EmployeeComputerManager(IComputerFactory computerFactory)
    {
        _computerFactory = computerFactory;
    }

    public string GetComputerDetails()
    {
        IComputerBrand brand = _computerFactory.GetComputerBrand();
        IComputerProcessor processor = _computerFactory.GetComputerProcessor();
        IComputerType type = _computerFactory.GetComputerType();

        return string.Format("{0} {1} ({2})", brand.GetComputerBrand(),
                                              processor.GetComputerProcessor(),
                                              type.GetComputerType());
    }
}
