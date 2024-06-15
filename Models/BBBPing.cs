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

    internal class BBBPing
    {
        [JsonInclude]
        public DateTime sendTime { get; private set; }
        [JsonInclude]
        public DateTime returnTime { get; private set; }
        [JsonInclude]
        public String testData { get; private set; }

        public BBBPing()
        {
            this.sendTime = DateTime.MinValue;
            this.returnTime = DateTime.MinValue;
            this.testData = "";
        }
        public BBBPing(DateTime s, DateTime r, string testData)
        {
            this.sendTime = s;
            this.returnTime = r;
            this.testData = testData;
        }

        public string ToJSON()
        {
            return JsonSerializer.Serialize(this);
        }

        public void SetAsJSON(string json)
        {
            Debug.WriteLine($"json is {json}");
            BBBPing temp = BBBPing.FromJSON(json);
            Debug.WriteLine(temp);
            this.sendTime = temp.sendTime;
            this.returnTime = temp.returnTime;
            this.testData = temp.testData;
        }
        static public BBBPing FromJSON(string json)
        {
            try
            {
                return JsonSerializer.Deserialize<BBBPing>(json);
            }
            catch (Exception ex)
            {
                return new BBBPing();
            }
        }

    }
}
