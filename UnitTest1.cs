using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Example.Controllers;

namespace Example.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ListData dl = new ListData();

            var lst = dl.GetDataList();
            Assert.AreEqual(3, lst.Count);

        }
    }
}
