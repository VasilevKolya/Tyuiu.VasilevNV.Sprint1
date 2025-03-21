using System;
using Tyuiu.VasilevNV.Sprint1.Task3.V5.Lib;
namespace Tyuiu.VasilevNV.Sprint1.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpresion()
        {
            DataService ds = new DataService();
            double scale = 120;
            double distanceOnMap = 3.5;
            double expectedDistance = 420;

           
            var res = ds.DistanceLength(scale, distanceOnMap);

            
            Assert.AreEqual(expectedDistance, res);
        }
    }
}