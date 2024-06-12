using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCanInitDemoCalass()
        {
            BBB.Models.DemoClass demo = new BBB.Models.DemoClass("testing");

            Assert.IsNotNull(demo);
        }

        [TestMethod]
        public void TestCanUseDemoClass()
        {
            BBB.Models.DemoClass demo = new BBB.Models.DemoClass("testing");

            Assert.AreEqual("testing", demo.Name);
        }
    }
}
