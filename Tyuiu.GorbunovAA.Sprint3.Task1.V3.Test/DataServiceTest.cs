using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint3.Task1.V3.Lib;

namespace Tyuiu.GorbunovAA.Sprint3.Task1.V3.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            var a = ds.GetMultiplySeries(1, 10);
            Assert.AreEqual(a, a);
        }
    }
}
