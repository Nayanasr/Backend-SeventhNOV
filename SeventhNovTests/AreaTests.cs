using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeventhNov;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeventhNov.Tests
{
    [TestClass()]
    public class AreaTests
    {
        Area area = new Area();
        [TestMethod()]
        public void traingleTest()
        {
            Assert.AreEqual(3, area.traingle(2,3));
        }
    }
}