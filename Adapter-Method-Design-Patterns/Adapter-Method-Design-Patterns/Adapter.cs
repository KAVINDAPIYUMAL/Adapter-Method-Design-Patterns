using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Method_Design_Patterns
{
    public class Adapter : ILegacyService
    {
        private readonly NewService newService;

        public Adapter(NewService newService)
        {
            this.newService = newService;
        }

        public void LegacyRequest()
        {
            newService.NewRequest();
        }
    }
}
