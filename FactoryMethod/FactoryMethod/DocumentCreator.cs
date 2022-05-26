using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class DocumentCreator
    {
        private List<PageProduct> _pages = new List<PageProduct>();

        public DocumentCreator()
        {
            this.createPages();
        }

        public List<PageProduct> Pages { get => _pages; }

        public abstract void createPages();

        public override string ToString()
        {
            string content= "";
            foreach (var page in this.Pages)
            {
                content+= "  " + page.GetType().ToString();
            }

            return content;
        }
    }
}
