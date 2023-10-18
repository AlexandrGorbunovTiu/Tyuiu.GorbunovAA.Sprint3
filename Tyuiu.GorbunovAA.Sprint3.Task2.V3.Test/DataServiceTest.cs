using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint3.Task2.V3.Lib;

namespace Tyuiu.GorbunovAA.Sprint3.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValueExpression()
        {
            DataService ds = new DataService();
            var x = ds.GetSumSeries(1, 16);
            Assert.AreEqual(x, 1935.0);
        }
    }
}
