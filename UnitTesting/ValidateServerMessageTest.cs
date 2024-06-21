using BBB.ClientRESTHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestClass]
    public class ValidateServerMessageTest
    {
        [TestMethod]
        public void TestToJSONDefaultObj()
        {
            ValidateServerMessage message = new ValidateServerMessage();
            string json = message.ToJSON();
            Assert.AreEqual("{\"token\":\"\"}", json);
        }

        [TestMethod]
        public void TestToJSON()
        {
            ValidateServerMessage message = new ValidateServerMessage("thetoken");
            string json = message.ToJSON();
            Assert.AreEqual("{\"token\":\"thetoken\"}", json);
        }

        [TestMethod]
        public void TestSetAsJSON()
        {
            ValidateServerMessage message = new ValidateServerMessage();
            message.SetAsJSON("{\"token\":\"thetoken\"}");
            Assert.AreEqual(message.token, "thetoken", "test token");
        }

        [TestMethod]
        public void TestFromJSON()
        {
            ValidateServerMessage message = ValidateServerMessage.FromJSON("{\"token\":\"thetoken\"}");
            Assert.AreEqual(message.token, "thetoken", "test token");
        }

        [TestMethod]
        public void TestFailure()
        {
            ValidateServerMessage message = ValidateServerMessage.FromJSON("garbage");
            Assert.AreEqual(message.token, "");
        }

    }
}
