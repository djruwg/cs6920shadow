using BBB.ClientRESTHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBB.Controllers
{
    internal class AuthController
    {
        private RESTClient<ValidateClientMessage, ValidateServerMessage> restClient;
        
        public AuthController() {
            this.restClient = new RESTClient<ValidateClientMessage, ValidateServerMessage>();
        }


    }
}
