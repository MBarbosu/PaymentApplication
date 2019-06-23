using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApplication
{
    interface IServiceCaller
    {
        bool CallServices(CreditCard creditCard);
    }
}
