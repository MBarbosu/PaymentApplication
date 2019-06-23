using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace PaymentApplication
{
    class PaymentRepository : IPaymentRepository
    {
        PaymentCollection payments;

        XmlSerializer serializer = new XmlSerializer(typeof(PaymentCollection));

        string Filename { get; set; }
        
        public PaymentRepository(string filename="payments.xml")
        {

            Filename = filename;

            if (File.Exists(Filename))
            {
                using (System.IO.FileStream fs = System.IO.File.OpenRead(Filename))
                {
                    payments = (PaymentCollection)serializer.Deserialize(fs);
                }
            }
            else
            {
                payments = new PaymentCollection();
                payments.Payments = new List<Payment> { };
            }              

        }

        public void add(Payment payment)
        {
            List<Payment> new_payments = payments.Payments;
            new_payments.Add(payment);
            payments.Payments = new_payments;
        }

        public void save()
        {
            using (var fs = System.IO.File.Open(Filename, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, payments);
            }
        }
    }
}
