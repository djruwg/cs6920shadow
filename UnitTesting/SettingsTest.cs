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
    public class SettingsTest
    {
        [TestMethod]
        public void TestGetSettings()
        {
            SettingsDAL settingsDAL = new SettingsDAL();
            Settings settings = settingsDAL.GetSettings();
            Assert.AreEqual(settings.starturl, "http://westga.edu/");
        }
    }
}
