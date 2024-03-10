using Bridge.Abstraction;
using Bridge.ConcreteImplementor;
using Bridge.RefinedAbstractor;

Payment cardPayment = new CardPayment
{
    paymentSystem = new VisaPaymentSystem()
};

cardPayment.InitiatePayment();

Payment netBankingPayment = new NetBankingPayment
{
    paymentSystem = new PayPalPaymentSystem()
};

netBankingPayment.InitiatePayment();
