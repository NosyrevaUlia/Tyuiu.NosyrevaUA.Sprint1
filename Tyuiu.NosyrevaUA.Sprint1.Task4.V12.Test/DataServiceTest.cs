using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint1.Task4.V12.Lib;

namespace Tyuiu.NosyrevaUA.Sprint1.Task4.V12.Test
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
            y = 4;
            double res = ds.Calculate(x, y);
            res = Math.Round(res, 3);
            Assert.AreEqual(res, 0);
           
        }
    }
}
