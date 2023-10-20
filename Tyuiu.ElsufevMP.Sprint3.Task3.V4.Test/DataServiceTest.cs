using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint3.Task3.V4.Lib;

namespace Tyuiu.ElsufevMP.Sprint3.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();

            string str = "plkjjdw cvjkl";
            char chr = 'j';

            string res = ds.DeleteCharInString(str, chr);
            string wait = "plk  dw cv kl";

            Assert.AreEqual(res, wait);
        }
    }
}
