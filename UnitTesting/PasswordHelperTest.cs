using BBB.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestClass]
    public class PasswordHelperTest
    {
        [TestMethod]
        public void TestPasswordHash()
        {
            string hash = PasswordHelper.Hash("test123");
            Assert.AreEqual("EFB9464849D2C79FE2B31A32A38E4D8B370AC8F6F7F6C885D365F11B7865C1A02EF32DE8BE7E4471B19169F75156BFE0D513558F94E362E4D29C6D2474C2FCB7", hash);
        }
    }
}
