using BBB.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using BBB.ClientRESTHelpers;

namespace UnitTesting
{
    [TestClass]
    public class EchoTest
    {
        [TestMethod]
        public void TestFromJSON()
        {
            Echo echo = Echo.FromJSON("{\"message\": \"test message\"}");
            Assert.AreEqual("test message", echo.message);
        }

        [TestMethod]
        public void TestToJSON()
        {
            Echo echo = Echo.FromJSON("{\"message\": \"test message\"}");
            string json = echo.ToJSON();
            Assert.AreEqual("{\"message\":\"test message\"}", json);
        }

        [TestMethod]
        public void TestSetAsJSON()
        {
            Echo echo = new Echo();
            echo.SetAsJSON("{\"message\": \"test message\"}");
            Assert.AreEqual("test message", echo.message);
        }
    }
}
