using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeventhNov;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeventhNov.Tests
{
    [TestClass()]
    public class TDD2Tests
    {
        TDD2 tdd2 = new TDD2();
        [TestMethod()]
        public void aresameTest() {

            int firstNumber = 1;
            int secondNumber = 1;

            object boxedFirstNumber = firstNumber;
            object boxedSecondNumber = secondNumber;
            Assert.AreSame(firstNumber, secondNumber);
        }
    }
}