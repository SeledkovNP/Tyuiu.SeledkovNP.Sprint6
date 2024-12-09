using Tyuiu.SeledkovNP.Sprint6.Task2.V27.Lib;
namespace Tyuiu.SeledkovNP.Sprint6.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            int start = -5;
            int end = 5;
            double[] wait = new double[11];
            wait[0] = -27.22;
            wait[1] = -22.25;
            wait[2] = -16.66;
            wait[3] = -11.04;
            wait[4] = -6.13;
            wait[5] = -3.00;
            wait[6] = 4.84;
            wait[7] = 8.86;
            wait[8] = 14.43;
            wait[9] = 20.18;
            wait[10] = 25.24;
            CollectionAssert.AreEquivalent(ds.GetMassFunction(start, end), wait);
        }
    }
}