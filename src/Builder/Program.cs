using Builder.FluentBuilder.ConcreteBuilder;
using Builder.FluentBuilder.Product;
using Builder.SimpleBuilder.ConcreteBuilder;
using Builder.SimpleBuilder.Product;

// Simple Builder
LaptopBuilder laptopBuilder = new();
laptopBuilder.AddKeyboard();
laptopBuilder.AddMemory(8192);
laptopBuilder.AddProcessor("M2");
laptopBuilder.AddStorage(524288);
laptopBuilder.AddTouchPad();
laptopBuilder.AddTouchScreen(false);

ComputerSystem computer = laptopBuilder.CreateSystem();

Console.WriteLine("Memory: {0} MB, Processor: {1}, Storage: {2} MB",
                   computer.MemorySize,
                   computer.ProcessorName,
                   computer.StorageSize);

// Fluent Builder
MobileBuilder mobileBuilder = new();

MobileSystem mobile = mobileBuilder.AddKeyPad(false)
                                   .AddMemory(8192)
                                   .AddOperatingSystem("iOS")
                                   .AddProcessor("A14")
                                   .AddSimCard()
                                   .AddStorage(524288)
                                   .AddTouchScreen(true)
                                   .CreateSystem();

Console.WriteLine("Memory: {0} MB, Processor: {1}, Storage: {2} MB, OperatingSystem: {3}",
                   mobile.MemorySize,
                   mobile.ProcessorName,
                   mobile.StorageSize,
                   mobile.OperatingSystem);
