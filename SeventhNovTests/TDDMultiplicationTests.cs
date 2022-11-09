using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeventhNov;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeventhNov.Tests
{
    [TestClass()]
    public class TDDMultiplicationTests
    {
        TDDMultiplication multi = new TDDMultiplication();
        [TestMethod()]
        public void productTest()
        {
            Assert.AreEqual(20, multi.product(10,2));
        }
    }
}