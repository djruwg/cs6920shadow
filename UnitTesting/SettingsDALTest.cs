﻿using BBB.ClientRESTHelpers;
using BBB.DAL;
using BBB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestClass]
    public class SettingsDALTest
    {

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            RestServiceMasterEndpointRoot.Instance.Mode = RestServiceMasterEndpointRoot.Modes.PROD;
        }

        [TestMethod]
        public void TestGetSettings()
        {
            RestServiceMasterEndpointRoot.Instance.Mode = RestServiceMasterEndpointRoot.Modes.PROD;
            SettingsDAL settingsDAL = new SettingsDAL();
            Settings settings = settingsDAL.GetSettings();
            Assert.AreEqual("https://www.westga.edu", settings.starturl);
        }
    }
}
