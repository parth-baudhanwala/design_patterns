using Bridge.Abstraction;

namespace Bridge.RefinedAbstractor;

public class CardPayment : Payment
{
    public override void InitiatePayment()
    {
        paymentSystem.ProcessPayment("Credit Card");
    }
}
