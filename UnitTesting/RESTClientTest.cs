using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBB.ClientRESTHelpers;

namespace UnitTesting
{
    [TestClass]
    public class RESTClientTest
    {
        private static RESTClient<Echo, Echo> _restClient;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            _restClient = new RESTClient<Echo, Echo> ();
        }
        //[ClassCleanup]
        //[TestInitialize]
        //[TestCleanup]

        [TestMethod]
        public void TestGetObjectAsyncGoodEndpoint()
        {
            RestServiceMasterEndpointRoot.Instance.Mode = "TEST";
            RESTClientReturnData<Echo> wrapper = Task.Run(() => _restClient.GetObjectAsync("/echo")).Result;
            Assert.IsTrue(wrapper.success, "testing wrapper.success");
            Assert.IsTrue(wrapper.containsData, "testing wrapper.containsData");
            Assert.AreEqual("get /echo",wrapper.obj.message);
        }

        [TestMethod]
        public void TestPutObjectAsyncGoodEndpoint()
        {

            RestServiceMasterEndpointRoot.Instance.Mode = "TEST";
            Echo echo = Echo.FromJSON("{ \"message\": \"put /echo\"}");
            RESTClientReturnData<Echo> wrapper = Task.Run(() => _restClient.PutObjectAsync("/echo", echo)).Result;
            Assert.IsTrue(wrapper.success, "testing wrapper.success");
            Assert.IsTrue(wrapper.containsData, "testing wrapper.containsData");
            Assert.AreEqual("put /echo", wrapper.obj.message);
        }

        [TestMethod]
        public void TestPostObjectAsyncGoodEndpoint()
        {
            RestServiceMasterEndpointRoot.Instance.Mode = "TEST";
            Echo echo = Echo.FromJSON("{ \"message\": \"post /echo\"}");
            RESTClientReturnData<Echo> wrapper = Task.Run(() => _restClient.PostObjectAsync("/echo", echo)).Result;
            Assert.IsTrue(wrapper.success, "testing wrapper.success");
            Assert.IsTrue(wrapper.containsData, "testing wrapper.containsData");
            Assert.AreEqual("post /echo", wrapper.obj.message);
        }

        [TestMethod]
        public void TestDeleteObjectAsyncGoodEndpoint()
        {
            RestServiceMasterEndpointRoot.Instance.Mode = "TEST";
            RESTClientReturnData<Echo> wrapper = Task.Run(() => _restClient.DeleteObjectAsync("/echo")).Result;
            Assert.IsTrue(wrapper.success, "testing wrapper.success");
            Assert.IsFalse(wrapper.containsData, "testing wrapper.containsData");
            Assert.IsNull(wrapper.obj);
        }

        [TestMethod]
        public void TestGetObjectAsyncBadEndpoint()
        {
            RestServiceMasterEndpointRoot.Instance.Mode = "TESTBAD";
            RESTClientReturnData<Echo> wrapper = Task.Run(() => _restClient.GetObjectAsync("/echo")).Result;
            Assert.IsFalse(wrapper.success, "testing wrapper.success");
            Assert.IsFalse(wrapper.containsData, "testing wrapper.containsData");
            Assert.IsNull(wrapper.obj);
        }

        [TestMethod]
        public void TestPutObjectAsyncBadEndpoint()
        {
            RestServiceMasterEndpointRoot.Instance.Mode = "TESTBAD";
            Echo echo = Echo.FromJSON("{ \"message\": \"put /echo\"}");
            RESTClientReturnData<Echo> wrapper = Task.Run(() => _restClient.PutObjectAsync("/echo", echo)).Result;
            Assert.IsFalse(wrapper.success, "testing wrapper.success");
            Assert.IsFalse(wrapper.containsData, "testing wrapper.containsData");
            Assert.IsNull(wrapper.obj);
        }

        [TestMethod]
        public void TestPostObjectAsyncBadEndpoint()
        {
            RestServiceMasterEndpointRoot.Instance.Mode = "TESTBAD";
            Echo echo = Echo.FromJSON("{ \"message\": \"post /echo\"}");
            RESTClientReturnData<Echo> wrapper = Task.Run(() => _restClient.PostObjectAsync("/echo", echo)).Result;
            Assert.IsFalse(wrapper.success, "testing wrapper.success");
            Assert.IsFalse(wrapper.containsData, "testing wrapper.containsData");
            Assert.IsNull(wrapper.obj);
        }

        [TestMethod]
        public void TestDeleteObjectAsyncBadEndpoint()
        {
            RestServiceMasterEndpointRoot.Instance.Mode = "TESTBAD";
            RESTClientReturnData<Echo> wrapper = Task.Run(() => _restClient.DeleteObjectAsync("/echo")).Result;
            Assert.IsFalse(wrapper.success, "testing wrapper.success");
            Assert.IsFalse(wrapper.containsData, "testing wrapper.containsData");
            Assert.IsNull(wrapper.obj);
        }

        //public async Task<RESTClientReturnData<TOUT>> GetObjectAsync(string restEndpoint)
        //public async Task<RESTClientReturnData<TOUT>> PutObjectAsync(string restEndpoint, TIN obj)
        //public async Task<RESTClientReturnData<TOUT>> PostObjectAsync(string restEndpoint, TIN obj)
        //public async Task<RESTClientReturnData<TOUT>> DeleteObjectAsync(string restEndpoint)
    }
}
