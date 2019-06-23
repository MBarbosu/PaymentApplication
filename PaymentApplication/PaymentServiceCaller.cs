using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApplication
{
    class PaymentServiceCaller : IServiceCaller
    {
        public bool CallServices(CreditCard creditCard)
        {
            bool succes = false;

            if (creditCard.Amount < 21)
            {
                succes = CheapPaymentService.MakePayment(creditCard);
                return succes;                
            }

            if (creditCard.Amount >= 21 && creditCard.Amount < 500)
            {
                succes = ExpensivePaymentService.MakePayment(creditCard);
                if (!succes)
                {
                    succes = CheapPaymentService.MakePayment(creditCard);
                }
                return succes;                
            }

            if (creditCard.Amount >= 500)
            {
                int tries = 0;        
                while (!succes && tries < 3)
                {
                    tries++;
                    succes = PremiumPaymentService.MakePayment(creditCard);
                }              
            }
            return succes;
        }
    }
}
