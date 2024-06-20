using BBB.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BBB.ClientRESTHelpers
{
    internal class Echo : BBBSerializableObject
    {
        [JsonInclude]

        public string message { get; private set; }
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
            Echo temp = Echo.FromJSON(json);
            this.message = temp.message;
        }

        /// <summary>
        /// Create a new Object from JSON string
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        static public Echo FromJSON(string json)
        {
            try
            {
                return JsonSerializer.Deserialize<Echo>(json);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($" Deserialize got {ex.Message}");
                return new Echo();
            }
        }
    }

}
