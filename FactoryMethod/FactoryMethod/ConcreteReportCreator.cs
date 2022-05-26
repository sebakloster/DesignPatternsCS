using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ConcreteReportCreator : DocumentCreator
    {
        public ConcreteReportCreator() : base()
        {
        }

        public override void createPages()
        {
            this.Pages.Add(new ConcreteIntroductionPage());
            this.Pages.Add(new ConcreteContentPage());
        }
    }
}
