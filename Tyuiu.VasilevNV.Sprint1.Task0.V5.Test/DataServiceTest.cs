using Tyuiu.VasilevNV.Sprint1.Task0.V5.Lib;

    namespace Tyuiu.VasilevNV.Sprint1.V0.Test
    {
        [TestClass]
        public class DataServiceTest
        {
            [TestMethod]
            public void TestMethod1()
            {
                DataService ds = new DataService();
                var res = ds.Calculate();
                Assert.AreEqual(2, res);
            }
        }
    }

    
