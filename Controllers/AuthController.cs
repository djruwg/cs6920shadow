using BBB.ClientRESTHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBB.Helpers;
using System.Diagnostics;

namespace BBB.Controllers
{
    internal class AuthController
    {
        private static RESTClient<ValidateClientMessage, ValidateServerMessage> _restClient = new RESTClient<ValidateClientMessage, ValidateServerMessage>();

        public Boolean ValidateUser(string username, string password)
        {
            Debug.WriteLine($"hashed password for :{password}: is :{PasswordHelper.Hash(password)}:");

            ValidateClientMessage message = new ValidateClientMessage(username, PasswordHelper.Hash(password));

            RESTClientReturnData<ValidateServerMessage> wrapper = Task.Run(() => _restClient.PostObjectAsync("/validate", message)).Result;
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

        public Boolean TestAuth()
        {
            RESTClientReturnData<ValidateServerMessage> wrapper = Task.Run(() => _restClient.GetObjectAsync("/testtoken")).Result;
            if (wrapper != null && wrapper.success && wrapper.containsData)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
