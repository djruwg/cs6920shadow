using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class MainWindowUnitTest
    {
        [TestMethod]
        public void TestCanInitMainWindow()
        {
            BBB.MainWindow mainWindow = new BBB.MainWindow();

            Assert.IsNotNull(mainWindow);
        }
    }
}
