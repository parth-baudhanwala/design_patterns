using Bridge.Implementor;

namespace Bridge.Abstraction;

public abstract class Payment
{
    public required IPaymentSystem paymentSystem;

    public abstract void InitiatePayment();
}
