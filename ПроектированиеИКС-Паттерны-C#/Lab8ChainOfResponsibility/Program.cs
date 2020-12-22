namespace Lab8ChainOfResponsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //определяем доступные классы
            var receiver = new Receiver(false, true, true) ;

            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHnadler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();


            //выстраиваем цепочку
            bankPaymentHandler.Successor = paypalPaymentHandler;
            paypalPaymentHandler.Successor = moneyPaymentHnadler;
            moneyPaymentHnadler.Successor = bankPaymentHandler;
            bankPaymentHandler.Handle(receiver);



        }
    }
}