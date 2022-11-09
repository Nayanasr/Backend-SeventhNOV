using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeventhNov;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeventhNov.Tests
{
    [TestClass()]
    public class TDDTests
    {
        TDD tdd = new TDD();
        [TestMethod()]
        public void sumTest()
        {
            Assert.AreEqual(10,tdd.sum(5,5));
        }
    }
}



