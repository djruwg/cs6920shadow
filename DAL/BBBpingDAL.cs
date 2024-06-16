using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBB.Helpers;
using BBB.Models;

namespace BBB.DAL
{
    internal class BBBpingDAL
    {
        static RESTClient<BBBPing> _restClient;

        public BBBpingDAL() 
        {
            _restClient = new RESTClient<BBBPing>();
        }

        public BBBPing getBBBPing(string endpoing)
        {
            return Task.Run(() => _restClient.GetObjectAsync("http://davide.classproj.us/api/ping")).Result;
        }

        public BBBPing putBBBPing(string endpoing, BBBPing obj)
        {
            string gotback = Task.Run(() => _restClient.PutObjectAsync("http://davide.classproj.us/api/ping",obj)).Result;
            BBBPing temp = new BBBPing();
            temp.SetAsJSON(gotback);
            return temp;
        }


    }
}
