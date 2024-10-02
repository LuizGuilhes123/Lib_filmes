public class CreditCardPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processando pagamento de R${amount} via Cartão de Crédito.");
    }
}

// PixPayment.cs
public class PixPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processando pagamento de R${amount} via PIX.");
    }
}
