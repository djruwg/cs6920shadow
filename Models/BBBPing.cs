using System;
using System.Collections.Generic;
using System.Linq;
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
            BBBPing temp = BBBPing.FromJSON(json);
            this.sendTime = temp.sendTime;
            this.returnTime = temp.returnTime;
            this.testData = temp.testData;
        }
        static public BBBPing FromJSON(string json)
        {
            return JsonSerializer.Deserialize<BBBPing>(json);
        }

    }
}
