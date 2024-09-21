using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TodikovDE.Sprint0.Task3.Lib;
namespace Tyuiu.TodikovDE.Spint0.Task3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Даниил";
            var res = DataService.GetMessage(name);


            Assert.AreEqual("Привет, Даниил", res);
        }
    }
}