using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBB.ClientRESTHelpers;

namespace UnitTesting
{
    [TestClass]
    internal class RestServiceMasterEndpointRootTest
    {
        [TestMethod]
        public void TestDefaults()
        {
            Assert.AreEqual(RestServiceMasterEndpointRoot.Instance.Mode, RestServiceMasterEndpointRoot.Modes.PROD);
            Assert.AreEqual(RestServiceMasterEndpointRoot.Instance.EndpointRoot, "http://cloud.classproj.us");
        }
    }
}
