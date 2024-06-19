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
    internal class SettingsDAL
    {
        static RESTClient<BBBPing, Settings> _restClient;
        static string _endpoint = "http://davide.classproj.us:8484/settings";

        SettingsDAL()
        {
            _restClient = new RESTClient<BBBPing, Settings>();
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
