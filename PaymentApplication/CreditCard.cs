using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApplication
{
    public class CreditCard
    {
        public string CreditCardNumber { get; set; }
        public string CardHolder { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int? SecurityCode { get; set; }
        public decimal Amount { get; set; }

        public CreditCard(string creditCardNumber, string cardHolder, DateTime expirationDate, decimal amount)
        {
            this.CreditCardNumber = creditCardNumber;
            this.CardHolder = cardHolder;
            this.ExpirationDate = expirationDate;
            this.Amount = amount;
        }

        public CreditCard(string creditCardNumber, string cardHolder, DateTime expirationDate, int securityCode, decimal amount)
        {
            this.CreditCardNumber = creditCardNumber;
            this.CardHolder = cardHolder;
            this.ExpirationDate = expirationDate;
            this.SecurityCode = securityCode;
            this.Amount = amount;
        }
    }
}
