﻿using BBB.Interface;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BBB.Models
{
    public class Settings : BBBSerializableObject
    {
        [JsonInclude]
        public String starturl { get; private set; }

        public Settings() {
            starturl = "https://www.google.com/";
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
            Settings temp = Settings.FromJSON(json);
            this.starturl = temp.starturl;
        }

        /// <summary>
        /// Create a new Object from JSON string
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        static public Settings FromJSON(string json)
        {
            try
            {
                return JsonSerializer.Deserialize<Settings>(json);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($" Deserialize got {ex.Message}");
                return new Settings();
            }
        }
    }
}
