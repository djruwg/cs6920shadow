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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing.Imaging;

namespace BBB.Helpers
{
    /// <summary>
    /// Class to handle talking to webserver that provides REST service
    /// </summary>
    internal class RESTClient<T> where T : BBBSerializableObject, new()
    {
        public RESTClient() { }

        const string _userid = "apiuser";
        const string _password = "apikey";
        
        public async Task<T> GetObjectAsync(string restEndpoint)
        {
            //string concatenated = $"{_userid}:{_password}";
            //string encoded = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(concatenated));
        
            string json ="";
            T tempObject = new T();

            using (var client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                Debug.WriteLine("into GetObjectAsync");

                try
                {
                    Debug.WriteLine(restEndpoint);
                    foreach (var header in client.DefaultRequestHeaders)
                    {
                        Debug.WriteLine($"{header.Key}: {string.Join(", ", header.Value)}");
                    }
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
            //string concatenated = $"{_userid}:{_password}";
            //string encoded = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(concatenated));

            string data = "{}";

            using (var client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var content = new StringContent(obj.ToJSON(), Encoding.UTF8, "application/json");

                try
                {
                    foreach (var header in client.DefaultRequestHeaders)
                    {
                        Debug.WriteLine($"{header.Key}: {string.Join(", ", header.Value)}");
                    }
                    var response = await client.PutAsync(restEndpoint, content);

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
