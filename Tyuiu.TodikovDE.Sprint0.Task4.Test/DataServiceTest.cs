using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TodikovDE.Sprint0.Task4.Lib;

namespace Tyuiu.TodikovDE.Sprint0.Task3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}