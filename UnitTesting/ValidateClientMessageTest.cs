using BBB.ClientRESTHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestClass]
    public class ValidateClientMessageTest
    {
        [TestMethod]
        public void TestToJSONDefaultObj()
        {
            ValidateClientMessage message = new ValidateClientMessage();
            string json = message.ToJSON();
            Assert.AreEqual("{\"username\":\"\",\"password\":\"\"}", json);
        }

        [TestMethod]
        public void TestToJSON()
        {
            ValidateClientMessage message = new ValidateClientMessage("theusername", "thepassword");
            string json = message.ToJSON();
            Assert.AreEqual("{\"username\":\"theusername\",\"password\":\"thepassword\"}", json);
        }

        [TestMethod]
        public void TestSetAsJSON()
        {
            ValidateClientMessage message = new ValidateClientMessage();
            message.SetAsJSON("{\"username\":\"theusername\",\"password\":\"thepassword\"}");
            Assert.AreEqual(message.username, "theusername", "test username");
            Assert.AreEqual(message.password, "thepassword", "test password");
        }

        [TestMethod]
        public void TestFromJSON()
        {
            ValidateClientMessage message = ValidateClientMessage.FromJSON("{\"username\":\"theusername\",\"password\":\"thepassword\"}");
            Assert.AreEqual(message.username, "theusername", "test username");
            Assert.AreEqual(message.password, "thepassword", "test password");
        }

        [TestMethod]
        public void TestFailure()
        {
            ValidateClientMessage message = ValidateClientMessage.FromJSON("garbage");
            Assert.AreEqual(message.username, "");
            Assert.AreEqual(message.password, "");

        }

    }
}
