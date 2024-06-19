using BBB.Interface;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BBB.ClientRESTHelpers
{
    internal class ValidateClientMessage : BBBSerializableObject
    {
        [JsonInclude]
        public String username { get; private set; }
        [JsonInclude]
        public String password { get; private set; }

        public ValidateClientMessage()
        {
            this.username = "";
            this.password = "";
        }

        public ValidateClientMessage(string username, string password)
        {
            this.username = username;
            this.password = password;
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
            ValidateClientMessage temp = ValidateClientMessage.FromJSON(json);
            this.username = temp.username;
            this.password = temp.password;
        }

        /// <summary>
        /// Create a new Object from JSON string
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        static public ValidateClientMessage FromJSON(string json)
        {
            try
            {
                return JsonSerializer.Deserialize<ValidateClientMessage>(json);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($" Deserialize got {ex.Message}");
                return new ValidateClientMessage();
            }
        }

    }
}
