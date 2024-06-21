using BBB.ClientRESTHelpers;
using BBB.Controllers;

namespace UnitTesting
{
    [TestClass]
    public class SettingsControllerTest
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
            Assert.AreEqual(settings.startupURL, "https://www.westga.edu");
        }
    }
}
