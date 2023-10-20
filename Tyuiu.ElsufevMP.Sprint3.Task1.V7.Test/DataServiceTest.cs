using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint3.Task1.V7.Lib;

namespace Tyuiu.ElsufevMP.Sprint3.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 9;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = -0.93;

            Assert.AreEqual(wait, res);
        }
    }
}
