using BBB.ClientRESTHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestClass]
    public class RESTClientReturnDataTest
    {
        // Not testing default set/get functions
        [TestMethod]
        public void TestConstructor()
        {
            RESTClientReturnData<BlankRestMessage> restClientReturnData = new RESTClientReturnData<BlankRestMessage>();
            Assert.IsFalse(restClientReturnData.success);
            Assert.IsFalse(restClientReturnData.containsData);
            Assert.IsNull(restClientReturnData.obj);
            // This may seem silly since I just assigned it an object of that type, but if return data didn't set the type correctly the line would cause an exception so this proves the Generic type works
            restClientReturnData.obj = new BlankRestMessage();
            Assert.IsInstanceOfType(restClientReturnData.obj, typeof(BlankRestMessage));
        }
    }
}
