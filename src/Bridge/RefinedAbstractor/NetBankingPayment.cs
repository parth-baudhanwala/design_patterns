using Bridge.Abstraction;

namespace Bridge.RefinedAbstractor;

public class NetBankingPayment : Payment
{
    public override void InitiatePayment()
    {
        _paymentSystem.ProcessPayment("Net Banking");
    }
}
