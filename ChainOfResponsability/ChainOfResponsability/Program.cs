using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PaymentProcessor basicProcessor = new BasicPaymentProcessor();
            PaymentProcessor normalProcessor = new NormalPaymentProcessor();
            PaymentProcessor blackProcessor = new BlackPaymentProcessor();

            normalProcessor.setNextProcessor(blackProcessor);
            basicProcessor.setNextProcessor(normalProcessor);

            basicProcessor.processPayment(999);
            basicProcessor.processPayment(9999);
            basicProcessor.processPayment(99999);
        }
    }
}
