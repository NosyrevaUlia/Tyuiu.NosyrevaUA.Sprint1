using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint1.Task3.V4.Lib;

namespace Tyuiu.NosyrevaUA.Sprint1.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int amount = 7;
            double priceNotebook = 2.75;
            double priceCover = 0.5;
            var res = ds.PurchaseAmount(priceNotebook, priceCover, amount);
            Assert.AreEqual(res, 22.75);

        }
    }
}
