using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NosyrevaUA.Sprint1.Task6.V18.Lib;
namespace Tyuiu.NosyrevaUA.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest 
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string s = "675";
            Assert.AreEqual(true,ds.CheckNumber(s));
        }
    }
}
