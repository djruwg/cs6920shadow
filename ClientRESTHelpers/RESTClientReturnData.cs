using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBB.ClientRESTHelpers
{
    internal class RESTClientReturnData<T>
    {
        public Boolean success {  get; set; }
        public Boolean containsData { get; set; }

        public T obj { get; set; }

        public RESTClientReturnData()
        {
            success = false;
            containsData = false;
        }

    }
}
