using BBB.ClientRESTHelpers;
using BBB.Controllers;
using BBB.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
 
        public void TestGoodLogin()
        {
            AuthController auth = new AuthController();
            Boolean result = auth.ValidateUser("admin", "test123");
            Assert.IsTrue(result);
            result = auth.TestAuth();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestUsernameLogin()
        {
            AuthController auth = new AuthController();
            Boolean result = auth.ValidateUser("wrong", "test123");
            Assert.IsFalse(result);
            result = auth.TestAuth();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestBadPasswordLogin()
        {
            AuthController auth = new AuthController();
            Boolean result = auth.ValidateUser("admin", "wrong");
            Assert.IsFalse(result);
            result = auth.TestAuth();
            Assert.IsFalse(result);
        }
    }
}



