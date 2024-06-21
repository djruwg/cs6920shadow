using Moq;

namespace UnitTesting
{
    [TestClass]
    public class RenderingUserControlUnitTest
    {
        Mock<BBB.UserControls.RenderingUserControlInterface>  mockInterface = new Mock<BBB.UserControls.RenderingUserControlInterface>();

        [TestMethod]
        public void TestCanInitRenderingUserControl()
        {
            BBB.UserControls.RenderingUserControl rendering = new BBB.UserControls.RenderingUserControl(mockInterface.Object);

            Assert.IsNotNull(rendering);
        }

        [TestMethod]
        public void TestRenderingUserControlCanGoToURL()
        {
            BBB.UserControls.RenderingUserControl rendering = new BBB.UserControls.RenderingUserControl(mockInterface.Object);

            rendering.GoToURL("https://www.google.com");

            Assert.AreEqual("https://www.google.com/", rendering.GetUrl());
        }

        [TestMethod]
        public void TestRenderingUserControlCanNotGoBack()
        {
            BBB.UserControls.RenderingUserControl rendering = new BBB.UserControls.RenderingUserControl(mockInterface.Object);

            rendering.GoToURL("https://www.google.com");

            Assert.IsFalse(rendering.CanGoBack());
        }

        [TestMethod]
        public void TestRenderingUserControlCanNotGoForward()
        {
            BBB.UserControls.RenderingUserControl rendering = new BBB.UserControls.RenderingUserControl(mockInterface.Object);

            rendering.GoToURL("https://www.google.com");

            Assert.IsFalse(rendering.CanGoForward());
        }
    }
}
