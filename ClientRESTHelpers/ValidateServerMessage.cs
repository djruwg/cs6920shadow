using BBB.Interface;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BBB.ClientRESTHelpers
{
    internal class ValidateServerMessage : BBBSerializableObject
    {
        [JsonInclude]
        public String token { get; private set; }

        public ValidateServerMessage()
        {
            this.token = "";
        }

        public ValidateServerMessage(string token)
        {
            this.token = token;
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
            ValidateServerMessage temp = ValidateServerMessage.FromJSON(json);
            this.token = temp.token;
        }

        /// <summary>
        /// Create a new Object from JSON string
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        static public ValidateServerMessage FromJSON(string json)
        {
            try
            {
                return JsonSerializer.Deserialize<ValidateServerMessage>(json);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($" Deserialize got {ex.Message}");
                return new ValidateServerMessage();
            }
        }


    }
}
