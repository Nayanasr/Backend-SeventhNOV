using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeventhNov;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeventhNov.Tests
{
    [TestClass()]
    public class perimeterTests
    {
        perimeter perimeter = new perimeter();

        [TestMethod()]
        public void rectangleTest()
        {
            Assert.AreEqual(16, perimeter.rectangle(4,4));
        }
    }
}