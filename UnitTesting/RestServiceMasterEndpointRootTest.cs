using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBB.ClientRESTHelpers;

namespace UnitTesting
{
    [TestClass]

    // We don't test every endpoint because those change for testing senarios and are un-important for production code.
    // We do validate that the default which is PROD return correctly.
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
