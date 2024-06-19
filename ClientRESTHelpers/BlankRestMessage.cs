using BBB.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BBB.ClientRESTHelpers
{
    /// <summary>
    /// This is just a placeholder type you can use when you need a RESTClient but that client doesn't need to send or receive a message.
    /// Use BlankRestMessage for TIN if you aren't sending any data, or for TOUT if you aren't returning any data.
    /// </summary>
    internal class BlankRestMessage : BBBSerializableObject
    {
        /// <summary>
        /// Convert current Object into a JSON representation.
        /// </summary>
        /// <returns></returns>
        public string ToJSON()
        {
            return "{}";
        }

        /// <summary>
        /// Set the values of the current Object based on JSON string 
        /// </summary>
        /// <param name="json"></param>
        public void SetAsJSON(string json)
        {            
        }

        /// <summary>
        /// Create a new Object from JSON string
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        static public BlankRestMessage FromJSON(string json)
        {
            return new BlankRestMessage();
        }
    }
}
