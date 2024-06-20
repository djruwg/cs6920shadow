using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBB.ClientRESTHelpers;


namespace UnitTesting
{
    [TestClass]
    public class BearerTokenTest
    {

        [TestMethod]
        public void TestReadTokenWhenSet()
        {
            BearerToken.Instance.Token = "some random token";
            Assert.IsTrue(BearerToken.Instance.Status);
            Assert.AreEqual("some random token", BearerToken.Instance.Token);
        }

        [TestMethod]
        public void TestReadTokenWhenChanged()
        {
            BearerToken.Instance.Token = "some random token";
            Assert.IsTrue(BearerToken.Instance.Status);
            Assert.AreEqual("some random token", BearerToken.Instance.Token);
            BearerToken.Instance.Token = "some new token";
            Assert.IsTrue(BearerToken.Instance.Status);
            Assert.AreEqual("some new token", BearerToken.Instance.Token);
        }

        [TestMethod]
        public void TestSetTokenStatusTrueWhenTrue()
        {
            BearerToken.Instance.Token = "some random token";
            Assert.IsTrue(BearerToken.Instance.Status, "Token is true");
            BearerToken.Instance.Status = true;
            Assert.IsTrue(BearerToken.Instance.Status, "Token stays true");
            Assert.AreEqual("some random token", BearerToken.Instance.Token);
        }

        [TestMethod]
        public void TestSetTokenBlankSetsStatusFalse()
        {
            BearerToken.Instance.Token = "";
            Assert.IsFalse(BearerToken.Instance.Status);
            Assert.AreEqual("", BearerToken.Instance.Token);
        }

        [TestMethod]
        public void TestSetTokenFalseInvalidatesToken()
        {
            BearerToken.Instance.Token = "some random token";
            Assert.IsTrue(BearerToken.Instance.Status);
            Assert.AreEqual("some random token", BearerToken.Instance.Token);
            BearerToken.Instance.Status = false;
            Assert.IsFalse(BearerToken.Instance.Status);
            Assert.AreEqual("", BearerToken.Instance.Token);
        }


    }
}


