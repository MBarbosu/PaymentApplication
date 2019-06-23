using System;

namespace PaymentApplication
{
    class PaymentApplication
    {
        static void Main()
        {            
            PaymentServiceCaller paymentServiceCaller = new PaymentServiceCaller();
            CreditCardValidator creditCardValidator = new CreditCardValidator();

            PaymentProcessor processor = new PaymentProcessor(creditCardValidator, paymentServiceCaller);

            CreditCard creditCard1 = new CreditCard("123456a812345678", "someone", new DateTime(2015, 8, 12), 15);
            processor.ProcessPayment(creditCard1);

            CreditCard creditCard2 = new CreditCard("1234567812345678", "me", new DateTime(2020, 8, 12), 350);
            processor.ProcessPayment(creditCard2);       
            Console.ReadLine();
        }
    }
}
