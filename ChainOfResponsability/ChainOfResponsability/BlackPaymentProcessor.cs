using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class BlackPaymentProcessor : PaymentProcessor
    {
        private PaymentProcessor nextProcessor;
        public override void processPayment(double amount)
        {
            if (amount > 100000)
            {
                nextProcessor.processPayment(amount);
            }
            else
            {
                Console.WriteLine("Payment procceced by " + this.GetType().Name + " amount: " + amount);
            }
        }

        public override void setNextProcessor(PaymentProcessor nextProcessor)
        {
            this.nextProcessor = nextProcessor;
        }
    }
}
