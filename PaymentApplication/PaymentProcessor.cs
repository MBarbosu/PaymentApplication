using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PaymentApplication
{
    class PaymentProcessor
    {
        readonly IValidator _creditCardValidator;
        readonly IServiceCaller _paymentServiceCaller;

        public PaymentProcessor(IValidator creditCardValidator, IServiceCaller paymentServiceCaller)
        {
            _creditCardValidator = creditCardValidator;
            _paymentServiceCaller = paymentServiceCaller;
        }

        string status = "failed";
        public void ProcessPayment(CreditCard creditCard)
        {
            if (_creditCardValidator.Validate(creditCard))
            {
                if (_paymentServiceCaller.CallServices(creditCard))
                {
                    Console.WriteLine("Payment done!");
                    status = "succes";                    
                }
            }

            Payment payment = new Payment();
            payment.Amount = creditCard.Amount;
            payment.CardHolder = creditCard.CardHolder;
            payment.CardNumber = creditCard.CreditCardNumber;
            payment.time = DateTime.Now;
            payment.status = status;

            var repo = new PaymentRepository();
            repo.add(payment);
            repo.save();

        }
    }
}
