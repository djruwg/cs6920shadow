﻿using Microsoft.Testing.Platform.Extensions.Messages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestClass]
    public class RenderingUserControlUnitTest : BBB.UserControls.RenderingUserControlInterface
    {
        [TestMethod]
        public void TestCanInitRenderingUserControl()
        {
            BBB.UserControls.RenderingUserControl rendering = new BBB.UserControls.RenderingUserControl(this);

            Assert.IsNotNull(rendering);
        }

        [TestMethod]
        public void TestRenderingUserControlCanGoToURL()
        {
            BBB.UserControls.RenderingUserControl rendering = new BBB.UserControls.RenderingUserControl(this);

            rendering.GoToURL("https://www.google.com");

            Assert.AreEqual("https://www.google.com/", rendering.GetUrl());
        }

        [TestMethod]
        public void TestRenderingUserControlCanNotGoBack()
        {
            BBB.UserControls.RenderingUserControl rendering = new BBB.UserControls.RenderingUserControl(this);

            rendering.GoToURL("https://www.google.com");

            Assert.IsFalse(rendering.CanGoBack());
        }

        [TestMethod]
        public void TestRenderingUserControlCanNotGoForward()
        {
            BBB.UserControls.RenderingUserControl rendering = new BBB.UserControls.RenderingUserControl(this);

            rendering.GoToURL("https://www.google.com");

            Assert.IsFalse(rendering.CanGoForward());
        }

        bool loaded = false;

        [TestMethod]
        public async Task TestRenderingUserControlCanGoBack()
        {
            BBB.UserControls.RenderingUserControl rendering = new BBB.UserControls.RenderingUserControl(this);

            rendering.GoToURL("https://www.google.com");
                
            // await Task.Delay(5000);
            // await Task.Run(() => { while (loaded == false); });

            //string script = @"
            //(function() {
            //    var link = document.querySelector('a');
            //    if (link) {
            //        link.click();
            //    }
            //})();";

            //await rendering.RunScriptAsync(script);

            // Assert.IsTrue(rendering.CanGoBack());
        }

        public void RenderingUserControlEvent(object sender, EventArgs e)
        {
            loaded = true;
        }
    }
}
