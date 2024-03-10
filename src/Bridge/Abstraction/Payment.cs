using Bridge.Implementor;

namespace Bridge.Abstraction;

public abstract class Payment
{
    public required IPaymentSystem _paymentSystem;

    public abstract void InitiatePayment();
}
