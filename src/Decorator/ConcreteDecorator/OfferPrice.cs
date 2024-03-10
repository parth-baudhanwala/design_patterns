using Decorator.Component;

namespace Decorator.ConcreteDecorator;

public class OfferPrice : CarDecorator
{
    public OfferPrice(ICar car) : base(car) { }

    public override double GetDicountPrice() => 0.8 * GetPrice();
}
