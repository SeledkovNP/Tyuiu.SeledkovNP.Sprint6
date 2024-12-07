using Tyuiu.SeledkovNP.Sprint6.Task0.V3.Lib;
namespace Tyuiu.SeledkovNP.Sprint6.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double war = 4.154;
            Assert.AreEqual(res, war);

        }
    }
}