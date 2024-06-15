using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BBB.Models
{

    internal class Ping
    {
        [JsonInclude]
        public DateTime sendingTime { get; private set; }
        [JsonInclude]
        public DateTime returnTime { get; private set; }
        [JsonInclude]
        public String testData { get; private set; }

        public Ping(DateTime s, DateTime r, string testDate)
        {
            this.sendingTime = s;
            this.returnTime = r;
            this.testData = testData;
        }

        public string ToJSON()
        {
            return JsonSerializer.Serialize(this);
        }

        public void SetAsJSON(string json)
        {
            Ping temp = Ping.FromJSON(json);
            this.sendingTime = temp.sendingTime;
            this.returnTime = temp.returnTime;
            this.testData = temp.testData;
        }
        static public Ping FromJSON(string json)
        {
            return JsonSerializer.Deserialize<Ping>(json);
        }

    }
}
