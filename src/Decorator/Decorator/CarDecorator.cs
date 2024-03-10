using Decorator.Component;

namespace Decorator;

public abstract class CarDecorator : ICar
{
    private readonly ICar _car;

    public CarDecorator(ICar car)
    {
        _car = car;
    }

    public string Model => _car.Model;

    public double GetPrice() => _car.GetPrice();

    public abstract double GetDicountPrice();
}
