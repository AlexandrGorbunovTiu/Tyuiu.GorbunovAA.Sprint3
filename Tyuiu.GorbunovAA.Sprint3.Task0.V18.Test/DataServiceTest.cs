using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint3.Task0.V18.Lib;

namespace Tyuiu.GorbunovAA.Sprint3.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetSumSeries(1, 6);
            Assert.AreEqual(res, 26.263474053737);
        }
    }
}
