using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Program
    {

        public static void Main(string[] args)
        {
            List<DocumentCreator> documents = new List<DocumentCreator>();

            DocumentCreator report = new ConcreteReportCreator();
            DocumentCreator resume = new ConcreteResumeCreator();
            documents.Add(report);
            documents.Add(resume);

            foreach (DocumentCreator document in documents)
            {
                Console.WriteLine("Documento: " + document.GetType().ToString() + "  paginas: " + document.ToString());
            }
        }

    }
}
