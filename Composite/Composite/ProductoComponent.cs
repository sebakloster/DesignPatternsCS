using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class ProductoComponent 
    {
        private double price;

        public double Price { get => price; set => price = value; }

        public abstract void Add(ProductoComponent p);
        public abstract void Remove(ProductoComponent p);
        public abstract List<ProductoComponent> getChildren();
        public abstract double calcularTotal();
    }
}
