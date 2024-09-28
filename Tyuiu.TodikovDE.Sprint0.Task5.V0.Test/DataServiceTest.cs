using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TodikovDE.Sprint0.Task5.V0.Lib;
namespace Tyuiu.TodikovDE.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void CheckSubtracnionValid()
        {
            Assert.AreEqual(10, DataService.Subtraction(5, 10));
        }
        [TestMethod]
        public void CheckMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(5, 10));
        }
        [TestMethod]
        public void CheckDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}