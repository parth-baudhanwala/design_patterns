using Bridge.Abstraction;

namespace Bridge.RefinedAbstractor;

public class CardPayment : Payment
{
    public override void InitiatePayment()
    {
        _paymentSystem.ProcessPayment("Credit Card");
    }
}

