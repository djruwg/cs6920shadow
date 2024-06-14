using BBB.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class StringExtensionUnitTest
    {
        [TestMethod]
        public void TestStringExtentionTruncates()
        {
            string data = "123456789012345678";

            Assert.AreEqual("1234567890123456…", data.Truncate(16)); ;
        }

        [TestMethod]
        public void TestStringExtentionDoesNotTruncate()
        {
            string data = "123456789012345678";

            Assert.AreEqual("123456789012345678", data.Truncate(18)); ;
        }
    }
}
