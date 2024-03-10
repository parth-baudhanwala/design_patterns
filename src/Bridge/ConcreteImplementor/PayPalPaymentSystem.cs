using Bridge.Implementor;

namespace Bridge.ConcreteImplementor;

public class PayPalPaymentSystem : IPaymentSystem
{
    public void ProcessPayment(string paymentType)
    {
        Console.WriteLine($"Using PayPal payment gateway for {paymentType}.");
    }
}
