using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApplication
{
    class CheapPaymentService
    {
        public static bool MakePayment( CreditCard creditCard)
        {
            Console.WriteLine("Cheap Payment has been processed successfully…");
            return true;
        }
    }
}
