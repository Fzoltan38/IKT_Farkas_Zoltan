using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AuthenticationWCF_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceHello" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceHello.svc or ServiceHello.svc.cs at the Solution Explorer and start debugging.
    public class ServiceHello : IServiceHello
    {
        public string HelloWorld()
        {
            return "Hello world";
        }
    }
}
