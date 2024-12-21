using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NazarenkoVV.Sprint6.Task0.V17.Lib;
using System.IO;

namespace Tyuiu.NazarenkoVV.Sprint6.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 6.695;
            Assert.AreEqual(wait, res);
        }
    }
}