using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BBB.Interface;
using Microsoft.Testing.Platform.Extensions.Messages;
using BBB.Models;

namespace BBB.Helpers
{
    /// <summary>
    /// Class to handle talking to webserver that provides REST service
    /// </summary>
    internal class RESTClient<T> where T : BBBSerializableObject, new()
    {
        public RESTClient() { }
        public async Task<T> GetObjectAsync(string restEndpoint)
        {

            string json ="";
            T tempObject = new T();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                Debug.WriteLine("into GetObjectAsync");
                try
                {
                    Debug.WriteLine(restEndpoint);
                    HttpResponseMessage response = await client.GetAsync(restEndpoint);

                    if (response.IsSuccessStatusCode)
                    {
                        json = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        Debug.WriteLine("Status {0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Exception: {ex.Message}");
                }
            }

            tempObject.SetAsJSON(json);
 
            return tempObject; 
        }

        public async Task<string> PutObjectAsync(string restEndpoint, T obj)
        {
            string data = "{}";

            using (var client = new HttpClient())
            {
                var content = new StringContent(obj.ToJSON(), Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync(restEndpoint, content);

                    if (response.IsSuccessStatusCode)
                    {
                        data = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        Debug.WriteLine("Status {0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Exception: {ex.Message}");
                }
            }

            return data;
        }

        //public Boolean PutObjectAsync(string restEndpoint, string json)
        //{
        //    return false;
        //}

        public Boolean PatchObjectAsync()
        {
            return false;
        }

        public Boolean DeleteObjectAsync()
        {
            return false;
        }


    }
}
