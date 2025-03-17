using System;
using Tyuiu.VasilevNV.Sprint1.Task2.V6.Lib;
namespace Tyuiu.VasilevNV.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertMToKm(x);
            Assert.AreEqual(3.000, res);
        }
    }
}