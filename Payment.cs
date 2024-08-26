using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Payment
    {
        private IPayment _payment;

        public Payment(IPayment payment)
        {
            _payment = payment;
        }

        public void ProcessPayment(decimal amount)
        {
            _payment.Pay(amount);
        }
    }
}
