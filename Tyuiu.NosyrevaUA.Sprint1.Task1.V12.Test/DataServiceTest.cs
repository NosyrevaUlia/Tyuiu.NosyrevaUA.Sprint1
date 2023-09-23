﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint1.Task1.V12.Lib;

namespace Tyuiu.NosyrevaUA.Sprint1.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);

        }
    }
}
