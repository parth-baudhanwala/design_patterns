using Builder.FluentBuilder.AbstractBuilder;
using Builder.FluentBuilder.Product;

namespace Builder.FluentBuilder.ConcreteBuilder;

public class MobileBuilder : IMobileBuilder
{
    private readonly MobileSystem mobileSystem = new();

    public IMobileBuilder AddKeyPad(bool enable)
    {
        mobileSystem.HasKeyPad = enable;
        return this;
    }

    public IMobileBuilder AddMemory(int memorySize)
    {
        mobileSystem.MemorySize = memorySize;
        return this;
    }

    public IMobileBuilder AddOperatingSystem(string os)
    {
        mobileSystem.OperatingSystem = os;
        return this;
    }

    public IMobileBuilder AddProcessor(string processorName)
    {
        mobileSystem.ProcessorName = processorName;
        return this;
    }

    public IMobileBuilder AddSimCard()
    {
        mobileSystem.HasSimCard = true;
        return this;
    }

    public IMobileBuilder AddStorage(int storageSize)
    {
        mobileSystem.StorageSize = storageSize;
        return this;
    }

    public IMobileBuilder AddTouchScreen(bool enable)
    {
        mobileSystem.HasTouchScreen = enable;
        return this;
    }

    public MobileSystem CreateSystem()
    {
        return mobileSystem;
    }
}
