using Builder.SimpleBuilder.Product;

namespace Builder.SimpleBuilder.AbstractBuilder;

public interface ISystemBuilder
{
    void AddMemory(int memorySize);

    void AddStorage(int storageSize);

    void AddProcessor(string processorName);

    void AddKeyboard();

    void AddTouchPad();

    void AddTouchScreen(bool enable);

    ComputerSystem CreateSystem();
}
