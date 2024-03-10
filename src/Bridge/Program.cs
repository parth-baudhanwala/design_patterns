using Bridge.Abstraction;
using Bridge.ConcreteImplementor;
using Bridge.RefinedAbstractor;

Payment cardPayment = new CardPayment
{
    _paymentSystem = new VisaPaymentSystem()
};

cardPayment.InitiatePayment();

Payment netBankingPayment = new NetBankingPayment
{
    _paymentSystem = new PayPalPaymentSystem()
};

netBankingPayment.InitiatePayment();