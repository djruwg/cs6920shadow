﻿using BBB.Interface;
using BBB.ClientRESTHelpers;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;

namespace BBB.ClientRESTHelpers

{
    /// <summary>
    /// Class to handle talking to webserver that provides REST service
    /// </summary>
    internal class RESTClient<TIN, TOUT>
        where TIN : BBBSerializableObject, new()
        where TOUT : BBBSerializableObject, new()
    {

        public async Task<RESTClientReturnData<TOUT>> GetObjectAsync(string restEndpoint)
        {
            string fullendpoint = RestServiceMasterEndpointRoot.Instance.EndpointRoot + restEndpoint;
            Debug.WriteLine($" fullendpoint = {fullendpoint}");
            string json = "";
            RESTClientReturnData<TOUT> returnObj = new RESTClientReturnData<TOUT>();
            TOUT innerObj = new TOUT();

            using (var client = new HttpClient())
            {
                if (BearerToken.Instance.Status)
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", BearerToken.Instance.Token);
                }
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync(fullendpoint);

                    if (response.IsSuccessStatusCode)
                    {
                        json = await response.Content.ReadAsStringAsync();
                        innerObj.SetAsJSON(json);
                        returnObj.obj = innerObj;
                        returnObj.success = true;
                        returnObj.containsData = true;
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
            string fullendpoint = RestServiceMasterEndpointRoot.Instance.EndpointRoot + restEndpoint;
            string json = "{}";
            RESTClientReturnData<TOUT> returnObj = new RESTClientReturnData<TOUT>();
            TOUT innerObj = new TOUT();

            using (var client = new HttpClient())
            {
                if (BearerToken.Instance.Status)
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", BearerToken.Instance.Token);
                }
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    StringContent content = new StringContent(obj.ToJSON(), Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync(fullendpoint, content);

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
            string fullendpoint = RestServiceMasterEndpointRoot.Instance.EndpointRoot + restEndpoint;
            string json = "{}";
            RESTClientReturnData<TOUT> returnObj = new RESTClientReturnData<TOUT>();
            TOUT innerObj = new TOUT();

            using (var client = new HttpClient())
            {
                if (BearerToken.Instance.Status)
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", BearerToken.Instance.Token);
                }
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    StringContent content = new StringContent(obj.ToJSON(), Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(fullendpoint, content);

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
            string fullendpoint = RestServiceMasterEndpointRoot.Instance.EndpointRoot + restEndpoint;
            string json = "{}";
            RESTClientReturnData<TOUT> returnObj = new RESTClientReturnData<TOUT>();
            TOUT innerObj = new TOUT();

            using (var client = new HttpClient())
            {
                if (BearerToken.Instance.Status)
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", BearerToken.Instance.Token);
                }
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.DeleteAsync(fullendpoint);

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
