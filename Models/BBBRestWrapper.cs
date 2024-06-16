using BBB.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BBB.Models
{
    internal class BBBRestWrapper<T> : BBBSerializableObject
    {
        [JsonInclude]
        public Boolean status { get; private set; }
        [JsonInclude]
        public string message { get; private set; }
        [JsonInclude]
        public T obj { get; private set; }

        public BBBRestWrapper() 
        { 
            status = true;
            message = "";
        }

        public BBBRestWrapper(Boolean status, string message, T obj)
        {
            this.status = status;
            this.message = message; 
            this.obj = obj; 
        }

        /// <summary>
        /// Convert current Object into a JSON representation.
        /// </summary>
        /// <returns></returns>
        public string ToJSON()
        {
            return JsonSerializer.Serialize(this);
        }

        /// <summary>
        /// Set the values of the current Object based on JSON string 
        /// </summary>
        /// <param name="json"></param>
        public void SetAsJSON(string json)
        {
            Debug.WriteLine($"json is {json}");
            BBBRestWrapper<T> temp = BBBRestWrapper<T>.FromJSON(json);
            Debug.WriteLine(temp);
            this.status = temp.status;
            this.message = temp.message;
            this.obj = temp.obj;
        }

        /// <summary>
        /// Create a new Object from JSON string
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        static public BBBRestWrapper<T> FromJSON(string json)
        {
            try
            {
                return JsonSerializer.Deserialize<BBBRestWrapper<T>>(json);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($" Deserialize got {ex.Message}");
                return new BBBRestWrapper<T>();
            }
        }

    }
}
