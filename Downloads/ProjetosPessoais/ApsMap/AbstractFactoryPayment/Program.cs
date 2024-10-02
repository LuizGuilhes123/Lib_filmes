class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha o banco (A ou B): ");
        string bankChoice = Console.ReadLine();

        Console.WriteLine("Escolha o método de pagamento (CreditCard ou PIX): ");
        string paymentChoice = Console.ReadLine();

        IPaymentFactory paymentFactory;

        // Escolhe a fábrica de pagamento com base no banco selecionado pelo o User
        if (bankChoice == "A")
        {
            paymentFactory = new BankAPaymentFactory(paymentChoice);
        }
        else if (bankChoice == "B")
        {
            paymentFactory = new BankBPaymentFactory(paymentChoice);
        }
        else
        {
            throw new Exception("Banco não suportado.");
        }

        // Cria o pagamento e processa a transação
        IPayment payment = paymentFactory.CreatePayment();
        payment.ProcessPayment(100.00m); // Simulando um pagamento de R$100,00 no caso em questão
    }
}
