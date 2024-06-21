using BBB.ClientRESTHelpers;
using BBB.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{

    [TestClass]
    public class AuthControllerTest
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            RestServiceMasterEndpointRoot.Instance.Mode = RestServiceMasterEndpointRoot.Modes.PROD;
        }

        [TestMethod]
        public void TestGetDefaultURL()
        {
            SettingsController settings = new SettingsController();
            Assert.AreEqual("http://westga.edu/", settings.startupURL);
        }
    }
}
