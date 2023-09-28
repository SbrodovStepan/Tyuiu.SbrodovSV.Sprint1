using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SbrodovSV.Sprint1.Task7.V27.Lib;

namespace Tyuiu.SbrodovSV.Sprint1.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();
            double x = 5, y = 3, wait = 1.03, res = dataService.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
