using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApplication
{
    interface IValidator
    {
        bool Validate(CreditCard creditCard);
    }
}
