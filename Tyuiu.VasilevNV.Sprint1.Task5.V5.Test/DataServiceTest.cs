using Tyuiu.VasilevNV.Sprint1.Task5.V5.Lib;
namespace Tyuiu.VasilevNV.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
             double x = 32.597;
            int expectedDigit = 5;
            int res =ds.Calculate(x);

            // Assert
            Assert.AreEqual(expectedDigit, res);
        }
    }
}