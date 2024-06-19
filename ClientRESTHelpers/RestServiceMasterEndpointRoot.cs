using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBB.ClientRESTHelpers
{

    internal class RestServiceMasterEndpointRoot
    {
        private static readonly Lazy<RestServiceMasterEndpointRoot> instance = new Lazy<RestServiceMasterEndpointRoot>(() => new RestServiceMasterEndpointRoot());
        public static RestServiceMasterEndpointRoot Instance => instance.Value;

        private string _endpointRoot;
        private string _mode;

        public string EndpointRoot
        {
            get
            {
                return _endpointRoot;
            }
            private set
            {
                _endpointRoot = value;
            }
        }

        public string Mode
        {
            get
            {
                return _mode;
            }
            set
            {
                switch (value)
                {
                    case "PROD":
                        _endpointRoot = "http://cloud.classproj.us";
                        break;
                    case "TEST":
                        _endpointRoot = "http://davide.classproj.us:8484/";
                        break;
                    case "TESTBAD":
                        _endpointRoot = "http://davide.classproj.us:8484/bad";
                        break;
                    case "TESTDOWN":
                        _endpointRoot = "http://davide.classproj.us:9999/down";
                        break;
                    case "ROBTEST":
                        _endpointRoot = "http://rob.classproj.us:8080";
                        break;
                    default:
                        _endpointRoot = "http://cloud.classproj.us/";
                        break;
                }

            }
        }

        private RestServiceMasterEndpointRoot()
        {
            _mode = "PROD";
            _endpointRoot = "http://cloud.classprog.us/";
        }
    }

}
