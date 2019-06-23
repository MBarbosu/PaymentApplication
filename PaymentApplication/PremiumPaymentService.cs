using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApplication
{
    class PremiumPaymentService
    {
        public static bool MakePayment(CreditCard creditCard)
        {
            Console.WriteLine("Premium Payment has been processed successfully…");
            return true;
        }
    }
}
