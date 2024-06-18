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
using System.Net;
using System.Diagnostics.PerformanceData;

namespace BBB.ClientRESTHelpers

{
    /// <summary>
    /// Class to handle talking to webserver that provides REST service
    /// </summary>
    internal class RESTClient<TIN,TOUT>
        where TIN : BBBSerializableObject, new() 
        where TOUT : BBBSerializableObject, new()
    {
        
        public async Task<RESTClientReturnData<TOUT>> GetObjectAsync(string restEndpoint)
        {
            string json = "";
            RESTClientReturnData<TOUT> returnObj = new RESTClientReturnData<TOUT>();
            TOUT innerObj = new TOUT();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", BearerToken.token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
         
                try
                {
                    HttpResponseMessage response = await client.GetAsync(restEndpoint);

                    if (response.IsSuccessStatusCode)
                    {
                        json = await response.Content.ReadAsStringAsync();
                        innerObj.SetAsJSON(json);
                        returnObj.obj = innerObj;
                        returnObj.success = true;
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
            return returnObj; 
        }


        public async Task<RESTClientReturnData<TOUT>> PutObjectAsync(string restEndpoint, TIN obj)
        {
            string json = "{}";
            RESTClientReturnData<TOUT> returnObj = new RESTClientReturnData<TOUT>();
            TOUT innerObj = new TOUT();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", BearerToken.token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    StringContent content = new StringContent(obj.ToJSON(), Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync(restEndpoint, content);

                    if (response.IsSuccessStatusCode)
                    {
                        json = await response.Content.ReadAsStringAsync();
                        innerObj.SetAsJSON(json);
                        returnObj.obj = innerObj;
                        returnObj.containsData = true;
                        returnObj.success = true;
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
            return returnObj;
        }


        public async Task<RESTClientReturnData<TOUT>> PostObjectAsync(string restEndpoint, TIN obj)
        {
            string json = "{}";
            RESTClientReturnData<TOUT> returnObj = new RESTClientReturnData<TOUT>();
            TOUT innerObj = new TOUT();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", BearerToken.token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    StringContent content = new StringContent(obj.ToJSON(), Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(restEndpoint, content);

                    if (response.IsSuccessStatusCode)
                    {
                        json = await response.Content.ReadAsStringAsync();
                        innerObj.SetAsJSON(json);
                        returnObj.obj = innerObj;
                        returnObj.containsData = true;
                        returnObj.success = true;
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
            return returnObj;
        }


        public async Task<RESTClientReturnData<TOUT>> DeleteObjectAsync(string restEndpoint)
        {
            string json = "{}";
            RESTClientReturnData<TOUT> returnObj = new RESTClientReturnData<TOUT>();
            TOUT innerObj = new TOUT();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", BearerToken.token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.DeleteAsync(restEndpoint);

                    if (response.IsSuccessStatusCode)
                    {
                        json = await response.Content.ReadAsStringAsync();
                        //innerObj.SetAsJSON(json);
                        //returnObj.obj = innerObj;
                        //returnObj.containsData = true;
                        returnObj.success = true;
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
            return returnObj;
        }
    }
}
