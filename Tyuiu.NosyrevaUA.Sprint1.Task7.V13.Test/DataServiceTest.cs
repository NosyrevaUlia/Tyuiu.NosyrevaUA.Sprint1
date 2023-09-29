using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint1.Task7.V13.Lib;

namespace Tyuiu.NosyrevaUA.Sprint1.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x, y;
            x = 2;
            y = 3;
            double res = ds.Calculate(x, y);
            res = Math.Round(res, 3);
            Assert.AreEqual(res, 1.178);
        }
    }
}
