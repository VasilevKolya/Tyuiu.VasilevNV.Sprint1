using Tyuiu.VasilevNV.Sprint1.Task6.V9.Lib;
namespace Tyuiu.VasilevNV.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strTest = "1 * 2 * 3";
            DataService ds = new DataService();
            string res = ds.MoveLetterToStart(strTest);
            string wait = "123";


                Assert.AreEqual(wait, res);
            }
        }
    }

   