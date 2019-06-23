using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApplication 

{
    [Serializable]
    public class Payment
    {
        [System.Xml.Serialization.XmlElement]
        public DateTime time;

        [System.Xml.Serialization.XmlElement]
        public string CardNumber;

        [System.Xml.Serialization.XmlElement]
        public string CardHolder;

        [System.Xml.Serialization.XmlElement]
        public decimal Amount;

        [System.Xml.Serialization.XmlElement]
        public string status;
        public Payment(CreditCard creditCard)
        {
            this.Amount = creditCard.Amount;
            this.CardHolder = creditCard.CardHolder;
            this.CardNumber = creditCard.CreditCardNumber;
            this.time = DateTime.Now;
        }
        public Payment()  { }        
    }
}
