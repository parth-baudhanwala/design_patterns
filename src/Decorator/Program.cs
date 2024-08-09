using Decorator;
using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;

ICar ferrari = new Ferrari();
CarDecorator decorator = new OfferPrice(ferrari);

Console.WriteLine($"Model: {decorator.Model}, Price: {decorator.GetPrice()}, Discount Price: {decorator.GetDicountPrice()}");
