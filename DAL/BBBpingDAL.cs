using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BBB.Helpers;
using BBB.Models;

namespace BBB.DAL
{
    internal class BBBpingDAL
    {
        static RESTClient<BBBPing> _restClient;
        static string _baseURL;

        public BBBpingDAL() 
        {
            _restClient = new RESTClient<BBBPing>();
            _baseURL = "http://davide.classproj.us:8080";
        }

        public void SetBaseURL(string baseURL)
        {
            _baseURL = baseURL;
        }

        public BBBPing GetBBBPing(string endpoint)
        {
            //endpoint = _baseURL + endpoint; 
            //return Task.Run(() => _restClient.GetObjectAsync(endpoint)).Result;
            
            endpoint = _baseURL + endpoint;
            BBBRestWrapper<BBBPing> wrapper = Task.Run(() => _restClient.GetObjectAsyncWithStatus(endpoint)).Result;
            Debug.WriteLine($"status = {wrapper.status}");
            Debug.WriteLine($"message = {wrapper.message}");
            return wrapper.obj;
        }

        public BBBPing PutBBBPing(string endpoint, BBBPing obj)
        {
            endpoint = _baseURL + endpoint;
            string gotback = Task.Run(() => _restClient.PutObjectAsync(endpoint,obj)).Result;
            BBBPing temp = new BBBPing();
            temp.SetAsJSON(gotback);
            return temp;
        }

        public BBBPing PostBBBPing(string endpoint, BBBPing obj)
        {
            endpoint = _baseURL + endpoint;
            string gotback = Task.Run(() => _restClient.PostObjectAsync(endpoint, obj)).Result;

            BBBPing temp = new BBBPing();
            temp.SetAsJSON(gotback);
            return temp;
        }

        public BBBRestWrapper<BBBPing> GetBBBPingWithStatus(string endpoint)
        {
            endpoint = _baseURL + endpoint;
            return Task.Run(() => _restClient.GetObjectAsyncWithStatus(endpoint)).Result;
        }

        public BBBRestWrapper<BBBPing> DeleteBBBPingWithStatus(string endpoint)
        {
            endpoint = _baseURL + endpoint;
            return Task.Run(() => _restClient.DeleteObjectAsyncWithStatus(endpoint)).Result;
        }

    }
}
