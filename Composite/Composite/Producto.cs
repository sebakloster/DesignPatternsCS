using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Producto : ProductoComponent
    {
        public Producto(double price)
        {
            this.Price = price;
        }

        public override void Add(ProductoComponent p)
        {
            throw new NotImplementedException();
        }

        public override double calcularTotal()
        {
            return this.Price;
        }

        public override List<ProductoComponent> getChildren()
        {
            throw new NotImplementedException();
        }

        public override void Remove(ProductoComponent p)
        {
            throw new NotImplementedException();
        }
    }
}
