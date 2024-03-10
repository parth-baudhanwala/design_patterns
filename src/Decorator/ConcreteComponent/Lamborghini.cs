using Decorator.Component;

namespace Decorator.ConcreteComponent;

public sealed class Lamborghini : ICar
{
    public string Model => "350GT";

    public double GetPrice() => 600000;
}
