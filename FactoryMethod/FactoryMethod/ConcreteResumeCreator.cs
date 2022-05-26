using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ConcreteResumeCreator : DocumentCreator
    {
        public ConcreteResumeCreator() : base()
        {
        }

        public override void createPages()
        {
            this.Pages.Add(new ConcreteEducationPage());
            this.Pages.Add(new ConcreteExperiencePage());
        }
    }
}
