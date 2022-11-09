using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeventhNov;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeventhNov.Tests
{

    [TestClass()]
    public class shapeTests
    {
        shape shape = new shape();
        [TestMethod()]
        public void circleTest()
        {
            Assert.AreEqual(12.56, shape.circle(2));
        }
    }
}