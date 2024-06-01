using Bridge.Abstraction;

namespace Bridge.RefinedAbstractor;

public class NetBankingPayment : Payment
{
    public override void InitiatePayment()
    {
        paymentSystem.ProcessPayment("Net Banking");
    }
}
