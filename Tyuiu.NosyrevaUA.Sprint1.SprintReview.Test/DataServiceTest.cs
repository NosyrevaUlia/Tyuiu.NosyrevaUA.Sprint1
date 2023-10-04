using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint1.SprintReview.V23.Lib;

namespace Tyuiu.NosyrevaUA.Sprint1.SprintReview.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double res = ds.Calculate(x, y);
            res = Math.Round(res, 3);
            Assert.AreEqual(1.725,res);
        }
    }
}
