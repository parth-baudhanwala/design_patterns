using Builder.FluentBuilder.Product;

namespace Builder.FluentBuilder.AbstractBuilder;

public interface IMobileBuilder
{
    IMobileBuilder AddMemory(int memorySize);

    IMobileBuilder AddStorage(int storageSize);

    IMobileBuilder AddProcessor(string processorName);

    IMobileBuilder AddSimCard();

    IMobileBuilder AddOperatingSystem(string os);

    IMobileBuilder AddTouchScreen(bool enable);

    IMobileBuilder AddKeyPad(bool enable);

    MobileSystem CreateSystem();
}
