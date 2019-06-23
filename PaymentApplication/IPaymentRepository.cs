using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApplication
{
    public interface IPaymentRepository
    {
        void add(Payment payment);
        void save();
    }
}
