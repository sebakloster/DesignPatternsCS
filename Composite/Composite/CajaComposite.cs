using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class CajaComposite : ProductoComponent
    {

        private List<ProductoComponent> productoComponents = new List<ProductoComponent>();  
        public override void Add(ProductoComponent p)
        {
            this.productoComponents.Add(p);
        }

        public override double calcularTotal()
        {
            double total = 0;
           foreach (ProductoComponent p in productoComponents)
            {
                total += p.calcularTotal();
            }
            return total;
        }

        public override List<ProductoComponent> getChildren()
        {
            List<ProductoComponent> children = new List<ProductoComponent>();
            foreach (ProductoComponent p in productoComponents)
            {
                children.Add(p);
            }
            return children;
        }

        public override void Remove(ProductoComponent p)
        {
            this.productoComponents.Remove(p);
        }
    }
}
