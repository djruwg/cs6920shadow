using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBB.Interface;

namespace BBB.Helpers
{
    /// <summary>
    /// Class to handle talking to webserver that provides REST service
    /// </summary>
    internal class RESTClient<T> where T : BBBSerializableObject, new()
    {
        public RESTClient() { }
        public T GetObjectAsync()
        {
            string json ="";
            T tempObject = new T();
            // the get JSON
            tempObject.SetAsJSON(json);
            return new T(); 
        }

        public Boolean PutObjectAsync()
        {
            return false;
        }

        public Boolean PatchObjectAsync()
        {
            return false;
        }

        public Boolean DeleteObjectAsync()
        {
            return false;
        }


    }
}
