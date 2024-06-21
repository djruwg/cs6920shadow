using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using BBB.Models;

namespace UnitTesting
{
    [TestClass]
    public class SettingsTest
    {
        [TestMethod]
        public void TestToJSON()
        {
            Settings settings = new Settings();
            string json = settings.ToJSON();
            Assert.AreEqual("{\"starturl\":\"https://www.google.com/\"}", json);
        }

        [TestMethod]
        public void TestSetAsJSON()
        {
            Settings settings = new Settings();
            Assert.AreEqual(settings.starturl, "https://www.google.com/", "Default is correct");
            settings.SetAsJSON("{\"starturl\": \"https://www.westga.edu/\"}");
            Assert.AreEqual(settings.starturl, "https://www.westga.edu/", "Setting worked");
        }

        [TestMethod]
        public void TestFromJSON()
        {
            Settings settings = Settings.FromJSON("{\"starturl\": \"https://www.westga.edu/\"}");
            Assert.AreEqual(settings.starturl, "https://www.westga.edu/");
        }

        [TestMethod]
        public void TestFailure()
        {
            Settings settings = Settings.FromJSON("garbage");
            Assert.AreEqual(settings.starturl, "https://www.google.com/");
        }
    }
}
