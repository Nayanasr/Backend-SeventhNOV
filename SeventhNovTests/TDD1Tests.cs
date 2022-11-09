using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeventhNov;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeventhNov.Tests
{
    [TestClass()]
    public class TDD1Tests
    {
        TDD1 tdd1 = new TDD1();
        [TestMethod()]


        public void areequalTest() {

            int firstNumber = 1;
            int secondNumber = 1;
            object boxedFirstNumber = firstNumber;
            object boxedSecondNumber = secondNumber;
            Assert.AreEqual(firstNumber, secondNumber);
        }


    }
}