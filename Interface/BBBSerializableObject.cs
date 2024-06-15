using BBB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BBB.Interface
{
    /// <summary>
    /// Methods needed by the RESTClient to transmit and receive an Object over REST with JSON encoding
    /// </summary>
    internal interface BBBSerializableObject
    {
        /// <summary>
        /// Should Serialize an object as JSON
        /// </summary>
        /// <returns>JSON string representation of an object</returns>
        string ToJSON();

        /// <summary>
        /// Should set the Objects internal state to match that of the JSON version of the object
        /// </summary>
        /// <param name="json"></param>
        void SetAsJSON(string json);
    }
}
