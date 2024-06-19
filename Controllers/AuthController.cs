using BBB.ClientRESTHelpers;
using BBB.ClientRESTHelpers.BBB.ClientRESTHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBB.Controllers
{
    internal class AuthController
    {
        private static RESTClient<ValidateClientMessage, ValidateServerMessage> _restClient = new RESTClient<ValidateClientMessage, ValidateServerMessage>();

        public Boolean ValidateUser(string username, string password)
        {

            RESTClientReturnData<ValidateServerMessage> wrapper = Task.Run(() => _restClient.GetObjectAsync("/validate")).Result;
            if (wrapper != null && wrapper.success && wrapper.containsData)
            {
                //check login message
                BearerToken.Instance.Token = wrapper.obj.token;
                return true;
            }
            else
            {
                BearerToken.Instance.Status = false;
                return false;
            }
        }
    }
}
