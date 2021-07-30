using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ClearMeasure;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTestClass
    {
        [TestMethod]
        public void FizzBuzzProgram_MultiplesOfFifteen_FizzBuzz()
        {
          FizzBuzz app = new FizzBuzz();
          List<string> appList = app.Program(15);
          Assert.AreEqual("fizzbuzz", appList[14].ToLower());
        }

        [TestMethod]
        public void FizzBuzzProgram_MultiplesOfFive_FizzBuzz()
        {
          FizzBuzz app = new FizzBuzz();
          List<string> appList = app.Program(15);
          Assert.AreEqual("buzz", appList[4].ToLower());
        }

        [TestMethod]
        public void FizzBuzzProgram_MultiplesOfThree_FizzBuzz()
        {
          FizzBuzz app = new FizzBuzz();
          List<string> appList = app.Program(15);
          Assert.AreEqual("fizz", appList[2].ToLower());
        }
    }
}