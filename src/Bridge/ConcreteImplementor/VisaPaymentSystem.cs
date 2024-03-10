using Bridge.Implementor;

namespace Bridge.ConcreteImplementor;

public class VisaPaymentSystem : IPaymentSystem
{
    public void ProcessPayment(string paymentType)
    {
        Console.WriteLine($"Using Visa payment gateway for {paymentType}.");
    }
}
