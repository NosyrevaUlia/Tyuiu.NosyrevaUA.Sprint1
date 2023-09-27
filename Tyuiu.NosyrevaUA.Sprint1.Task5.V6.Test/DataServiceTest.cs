using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NosyrevaUA.Sprint1.Task5.V6.Lib;

namespace Tyuiu.NosyrevaUA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 17;
            Assert.AreEqual(ds.Calculate(k), 3);

            
        }
    }
}
