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
    public class RestServiceMasterEndpointRootTest
    {

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            RestServiceMasterEndpointRoot.Instance.Mode = RestServiceMasterEndpointRoot.Modes.PROD;
        }

        [TestMethod]
        public void TestProd()
        {
            Assert.AreEqual(RestServiceMasterEndpointRoot.Modes.PROD, RestServiceMasterEndpointRoot.Instance.Mode);
            Assert.AreEqual("http://cloud.classproj.us", RestServiceMasterEndpointRoot.Instance.EndpointRoot);
        }
    }
}
