using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeventhNov;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeventhNov.Tests
{
    [TestClass()]
    public class TDDDivisionTests
    {
        TDDDivision divide = new TDDDivision();
        [TestMethod()]
        public void divisionTest()
        {
            Assert.AreEqual(2,divide.division(4,2));
            Assert.AreEqual(10, divide.division(40, 4));
        }
    }
}