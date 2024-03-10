using Decorator.Component;

namespace Decorator.ConcreteComponent;

public sealed class Ferrari : ICar
{
    public string Model => "812 Superfast";

    public double GetPrice() => 800000;
}
