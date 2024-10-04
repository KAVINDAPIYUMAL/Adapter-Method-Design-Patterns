using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Method_Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            
            NewService newService = new NewService();
            ILegacyService legacyServiceAdapter = new Adapter(newService);

            
            legacyServiceAdapter.LegacyRequest();

            Console.ReadLine();
        }
    }
}
