using Tyuiu.SeledkovNP.Sprint6.Task5.V7.Lib;
namespace Tyuiu.SeledkovNP.Sprint6.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"C:\DataSprint6\InPutFileTask5V7.txt";
            FileInfo file = new FileInfo(path);
            bool res = file.Exists;
            bool wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}