using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SbrodovSV.Sprint1.Task3.V6.Lib;

namespace Tyuiu.SbrodovSV.Sprint1.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double distance = 67, gasFlow = 8.5, gasPrice = 6.5, wait = 74.04;
            DataService ds = new DataService();
            Assert.AreEqual(wait, ds.TravelCost(distance, gasFlow, gasPrice));
        }
    }
}
