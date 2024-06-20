using BBB.ClientRESTHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestClass]
    public class BlankRestMessageTest
    {
        // These test don't do much because BlankRestMessage is just a hard coded placeholder for when you need to give the RESTClient a type, but don't intend to use it.

        [TestMethod]
        public void TestFromJSON()
        {
            BlankRestMessage blankRestMessage = BlankRestMessage.FromJSON("{\"message\": \"test message\"}");
            string json = blankRestMessage.ToJSON();
            Assert.AreEqual("{}", json);
        }

        [TestMethod]
        public void TestToJSON()
        {
            BlankRestMessage blankRestMessage = new BlankRestMessage();
            string json = blankRestMessage.ToJSON();
            Assert.AreEqual("{}", json);
        }

        [TestMethod]
        public void TestSetAsJSON()
        {
            BlankRestMessage blankRestMessage = new BlankRestMessage();
            blankRestMessage.SetAsJSON("{\"message\": \"test message\"}");
            string json = blankRestMessage.ToJSON();
            Assert.AreEqual("{}", json);
        }
    }
}
