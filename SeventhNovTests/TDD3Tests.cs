using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeventhNov;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeventhNov.Tests
{
    [TestClass()]
    public class TDD3Tests
    {
        TDD3 tdd3 = new TDD3();
        [TestMethod()]
        public void arenotsameTest() {
            int i = 1;
            int j = i;


            // Two value types do *not* represent the same object:
            Assert.AreNotSame(i, j);
        }
    }
}