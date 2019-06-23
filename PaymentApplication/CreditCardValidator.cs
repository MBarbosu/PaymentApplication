using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaymentApplication
{
    class CreditCardValidator : IValidator
    {
        public bool Validate(CreditCard creditCard)
        {
            bool valid = true;
            if (!creditCard.CreditCardNumber.All(Char.IsDigit) || creditCard.CreditCardNumber.Length != 16) 
            {
                valid = false;
                Console.WriteLine("CreditCardNumber should contains 16 digits"); 
            }

            if (creditCard.ExpirationDate < DateTime.Now)
            {
                valid = false;
                Console.WriteLine("Card is expired");
            }

            if (!(creditCard.SecurityCode is null))
            {
                if (creditCard.SecurityCode < 100 || creditCard.SecurityCode > 999)
                {
                    valid = false;
                    Console.WriteLine("Security code should be 3 digits");
                }
            }

            if (creditCard.Amount < 0)
            {
                valid = false;
                Console.WriteLine("Amount should be positive");
            }

            return valid;
        }
    }
}
