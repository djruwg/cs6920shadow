using BBB.ClientRESTHelpers;
using BBB.Models;
using System.Diagnostics;

namespace BBB.DAL
{
    internal class BBBpingDAL
    {
        static RESTClient<BBBPing, BBBPing> _restClient;
        static string _baseURL;

        public BBBpingDAL()
        {
            _restClient = new RESTClient<BBBPing, BBBPing>();
            _baseURL = "http://davide.classproj.us:8484";
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
            RESTClientReturnData<BBBPing> wrapper = Task.Run(() => _restClient.GetObjectAsync(endpoint)).Result;
            Debug.WriteLine($"status = {wrapper.success}");
            Debug.WriteLine($"message = {wrapper.containsData}");
            return wrapper.obj;
        }

        public BBBPing PutBBBPing(string endpoint, BBBPing obj)
        {
            endpoint = _baseURL + endpoint;
            RESTClientReturnData<BBBPing> wrapper = Task.Run(() => _restClient.PutObjectAsync(endpoint, obj)).Result;
            Debug.WriteLine($"status = {wrapper.success}");
            Debug.WriteLine($"message = {wrapper.containsData}");
            return wrapper.obj;
        }

        public BBBPing PostBBBPing(string endpoint, BBBPing obj)
        {
            endpoint = _baseURL + endpoint;
            RESTClientReturnData<BBBPing> wrapper = Task.Run(() => _restClient.PostObjectAsync(endpoint, obj)).Result;
            Debug.WriteLine($"status = {wrapper.success}");
            Debug.WriteLine($"message = {wrapper.containsData}");
            return wrapper.obj;
        }

        public BBBPing DeleteBBBPing(string endpoint)
        {
            endpoint = _baseURL + endpoint;
            RESTClientReturnData<BBBPing> wrapper = Task.Run(() => _restClient.DeleteObjectAsync(endpoint)).Result;
            Debug.WriteLine($"status = {wrapper.success}");
            Debug.WriteLine($"message = {wrapper.containsData}");
            return wrapper.obj;
        }

    }
}
