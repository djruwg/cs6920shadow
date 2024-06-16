using BBB.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BBB.Models
{
/// <summary>
/// BBBPing (because Ping exists in C#) is a class that provides a simple object with timestamps and data that is useful for testing basic REST functions
/// </summary>
    internal class BBBPing : BBBSerializableObject
    {
        [JsonInclude]
        public DateTime clientTime { get; private set; }
        [JsonInclude]
        public DateTime serverTime { get; private set; }
        [JsonInclude]
        public String testData { get; private set; }

    /// <summary>
    /// Empty Constructor
    /// </summary>
    public BBBPing()
        {
            this.clientTime = DateTime.MinValue;
            this.serverTime = DateTime.MinValue;
            this.testData = "";
        }
        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="s">send time</param>
        /// <param name="r">return time</param>
        /// <param name="testData">test data</param>
        public BBBPing(DateTime c, DateTime s, string testData)
        {
            this.clientTime = c;
            this.serverTime = s;
            this.testData = testData;
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
            BBBPing temp = BBBPing.FromJSON(json);
            Debug.WriteLine(temp);
            this.clientTime = temp.clientTime;
            this.serverTime = temp.serverTime;
            this.testData = temp.testData;
        }

        /// <summary>
        /// Create a new Object from JSON string
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        static public BBBPing FromJSON(string json)
        {
            try
            {
                return JsonSerializer.Deserialize<BBBPing>(json);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($" Deserialize got {ex.Message}");
                return new BBBPing();
            }
        }

    }
}
