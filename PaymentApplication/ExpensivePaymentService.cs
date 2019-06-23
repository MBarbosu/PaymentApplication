using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApplication
{
    class ExpensivePaymentService
    {
        public static bool MakePayment(CreditCard creditCard)
        {
            Console.WriteLine("Expensive Payment has been processed successfully…");
            return true;
        }
    }
}
