using Builder.SimpleBuilder.AbstractBuilder;
using Builder.SimpleBuilder.Product;

namespace Builder.SimpleBuilder.ConcreteBuilder;

public class LaptopBuilder : ISystemBuilder
{
    private readonly ComputerSystem laptop = new();

    public void AddKeyboard()
    {
        laptop.HasKeyboard = true;
    }

    public void AddMemory(int memorySize)
    {
        laptop.MemorySize = memorySize;
    }

    public void AddProcessor(string processorName)
    {
        laptop.ProcessorName = processorName;
    }

    public void AddStorage(int storageSize)
    {
        laptop.StorageSize = storageSize;
    }

    public void AddTouchPad()
    {
        laptop.HasTouchPad = true;
    }

    public void AddTouchScreen(bool enable)
    {
        laptop.HasTouchScreen = enable;
    }

    public ComputerSystem CreateSystem()
    {
        return laptop;
    }
}
