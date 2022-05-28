using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Stock
    {
        private string symbol;
        private double price;
        private List<Investor> investors = new List<Investor>();

        public string Symbol { get => symbol; set => symbol = value; }

        public double Price {
        get { return this.price; }
        set { 
                this.price = value;
                notifyPriceChange();
            }
        
        }

        public Stock(string symbol, double price)
        {
            Symbol = symbol;
            Price = price;
        }   

        public void subscribeInvestor(Investor i)
        {
            investors.Add(i);
        }

        public void removeInvestor(Investor i)
        {
            investors.Remove(i);
        }

        public void notifyPriceChange()
        {
            foreach (Investor i in investors)
            {
                i.update(this.Price);
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Stock stock &&
                   Symbol == stock.Symbol;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Symbol);
        }
    }
}
