using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class BankTransferPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Ödeme banka transferi transferi ile {amount} olarak yapılmıştır.");
        }
    }
}
