public class BankAPaymentFactory : IPaymentFactory
{
    private string _paymentType;

    public BankAPaymentFactory(string paymentType)
    {
        _paymentType = paymentType;
    }

    public IPayment CreatePayment()
    {
        if (_paymentType == "CreditCard")
        {
            return new CreditCardPayment();
        }
        else if (_paymentType == "PIX")
        {
            return new PixPayment();
        }
        throw new Exception("Método de pagamento não suportado.");
    }
}

public class BankBPaymentFactory : IPaymentFactory
{
    private string _paymentType;

    public BankBPaymentFactory(string paymentType)
    {
        _paymentType = paymentType;
    }

    public IPayment CreatePayment()
    {
        if (_paymentType == "CreditCard")
        {
            return new CreditCardPayment();
        }
        else if (_paymentType == "PIX")
        {
            return new PixPayment();
        }
        throw new Exception("Método de pagamento não suportado.");
    }
}
