using BBB.ClientRESTHelpers;
using BBB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BBB.DAL
{
    public class SettingsDAL
    {
        static RESTClient<BlankRestMessage, Settings> _restClient;
        static string _endpoint = "/settings";

        public SettingsDAL()
        {
            _restClient = new RESTClient<BlankRestMessage, Settings>();
        }

        public Settings GetSettings()
        {
            
            RESTClientReturnData<Settings> wrapper = Task.Run(() => _restClient.GetObjectAsync(_endpoint)).Result;
            if (wrapper != null && wrapper.success && wrapper.containsData) {
                return wrapper.obj;
            }
            return new Settings();
        }
    }
}
