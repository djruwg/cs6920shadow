using BBB.Controllers;

namespace UnitTesting
{
    [TestClass]
    internal class SettingsControllerrTest
    {
        [TestMethod]
        public void TestGetDefaultURL()
        {
            SettingsController settings = new SettingsController();
            Assert.AreEqual("https://westga.edu/", settings.startupURL);
        }
    }
}
