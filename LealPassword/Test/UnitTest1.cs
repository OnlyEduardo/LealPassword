using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = "C:\\Users\\dute2\\OneDrive\\SenhasEdu.lp";
            var db = LealPassword.Data.ReadController.ReadDataBase(path);
            LealPassword.Data.WriteController.WriteDataBase(db, path, false);
            Assert.IsTrue(db != null);
        }
    }
}
