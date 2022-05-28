using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public abstract class PaymentProcessor
    {

        public abstract void setNextProcessor(PaymentProcessor nextProcessor);
        public abstract void processPayment(double amount);
    }
}
