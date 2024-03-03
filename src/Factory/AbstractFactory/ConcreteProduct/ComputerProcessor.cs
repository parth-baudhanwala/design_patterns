using Factory.AbstractFactory.AbstractProduct;
using Factory.Enum;

namespace Factory.AbstractFactory.ConcreteProduct;

public class I3 : IComputerProcessor
{
    public string GetComputerProcessor()
    {
        return ComputerProcessor.I3.ToString();
    }
}

public class M2 : IComputerProcessor
{
    public string GetComputerProcessor()
    {
        return ComputerProcessor.M2.ToString();
    }
}
