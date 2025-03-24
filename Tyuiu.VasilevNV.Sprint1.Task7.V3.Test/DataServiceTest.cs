using Tyuiu.VasilevNV.Sprint1.Task7.V3.Lib;
using System;
namespace Tyuiu.VasilevNV.Sprint1.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;
            double z = 4; 
            var res = ds.Calculate(x, y);
                
                Assert.AreEqual(z, res);
            }
        }
    }
