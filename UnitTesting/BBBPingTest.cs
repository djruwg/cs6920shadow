using BBB.Models;
using Microsoft.Testing.Platform.Extensions.Messages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestClass]
    public class BBBPingTest
    {
        [TestMethod]
        public void TestNewWithDefaults()
        {
            BBB.Models.BBBPing testObj = new BBB.Models.BBBPing();
            Assert.IsNotNull(testObj);
            Assert.AreEqual(testObj.clientTime, DateTime.MinValue);
            Assert.AreEqual(testObj.serverTime, DateTime.MinValue);
            Assert.AreEqual(testObj.testData, "");
        }

        [TestMethod]
        public void TestNewFullyDefined()
        {
            DateTime sendTime = DateTime.Now;
            DateTime returnTime = DateTime.MaxValue;
            string data = "this is test data";

            BBB.Models.BBBPing testObj = new BBB.Models.BBBPing(sendTime, returnTime, data);
            Assert.IsNotNull(testObj);
            Assert.AreEqual(testObj.clientTime, sendTime);
            Assert.AreEqual(testObj.serverTime, returnTime);
            Assert.AreEqual(testObj.testData, data);
        }

        [TestMethod]
        public void TestFromJSON()
        {
            DateTime sendTime = DateTime.MaxValue;
            DateTime returnTime = DateTime.MaxValue;
            string data = "this is test data";
            string jsonString = "{\"clientTime\":\"9999-12-31T23:59:59.9999999\",\"serverTime\":\"9999-12-31T23:59:59.9999999\",\"testData\":\"this is test data\"}";
            
            BBB.Models.BBBPing testObj = BBB.Models.BBBPing.FromJSON(jsonString);
            
            Assert.IsNotNull(testObj);
            Assert.AreEqual(testObj.clientTime, sendTime);
            Assert.AreEqual(testObj.serverTime, returnTime);
            Assert.AreEqual(testObj.testData, data);

        }

        [TestMethod]
        public void TestToJSON() 
        {
            DateTime sendTime = DateTime.MaxValue;
            DateTime returnTime = DateTime.MaxValue;
            string data = "this is test data";
            string jsonStringExpected = "{\"clientTime\":\"9999-12-31T23:59:59.9999999\",\"serverTime\":\"9999-12-31T23:59:59.9999999\",\"testData\":\"this is test data\"}";
            string jsonStringActual;

            BBB.Models.BBBPing testObj = new BBB.Models.BBBPing(sendTime, returnTime, data);
            jsonStringActual = testObj.ToJSON();

            Assert.AreEqual(jsonStringExpected, jsonStringActual);
            
        }

        [TestMethod]
        public void SetAsJSON()
        {
            DateTime sendTime = DateTime.MaxValue;
            DateTime returnTime = DateTime.MaxValue;
            string data = "this is test data";
            string jsonString = "{\"clientTime\":\"9999-12-31T23:59:59.9999999\",\"serverTime\":\"9999-12-31T23:59:59.9999999\",\"testData\":\"this is test data\"}";

            BBB.Models.BBBPing testObj = new BBB.Models.BBBPing();
            testObj.SetAsJSON(jsonString);

            Assert.AreEqual(testObj.clientTime, sendTime);
            Assert.AreEqual(testObj.serverTime, returnTime);
            Assert.AreEqual(testObj.testData, data);

        }

    }
}