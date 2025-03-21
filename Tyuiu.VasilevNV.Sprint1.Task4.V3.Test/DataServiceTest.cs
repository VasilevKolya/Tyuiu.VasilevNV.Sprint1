using Tyuiu.VasilevNV.Sprint1.Task4.V3.Lib;
namespace Tyuiu.VasilevNV.Sprint1.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 2;
            double expectedResult = Math.Sqrt(3 * x) / Math.Pow(x - y, 2);

            double res = ds.Calculate(x, y);
            Assert.AreEqual(expectedResult, res);
        }
    }
}