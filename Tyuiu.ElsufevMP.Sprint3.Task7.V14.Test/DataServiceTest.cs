using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint3.Task7.V14.Lib;

namespace Tyuiu.ElsufevMP.Sprint3.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheck()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;

            int len = stop - start + 1;

            double[] wait;
            wait = new double[len];

            wait[0] = ;
            wait[1] = ;
            wait[2] = ;
            wait[3] = ;
            wait[4] = ;
            wait[5] = ;
            wait[6] = ;
            wait[7] = ;
            wait[8] = ;
            wait[9] = ;
            wait[10] = ;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);

        }
    }
}
