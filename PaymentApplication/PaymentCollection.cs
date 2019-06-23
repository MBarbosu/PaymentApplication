using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace PaymentApplication
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("PaymentCollection")]
    public class PaymentCollection
    {
        [XmlArray("Payments")]
        [XmlArrayItem("Payment", typeof(Payment))]
        public List<Payment> Payments { get; set; }
    }
}
