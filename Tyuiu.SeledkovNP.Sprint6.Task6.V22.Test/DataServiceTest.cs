using Tyuiu.SeledkovNP.Sprint6.Task6.V22.Lib;
namespace Tyuiu.SeledkovNP.Sprint6.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Vaennet\source\repos\Tyuiu.SeledkovNP.Sprint6\Tyuiu.SeledkovNP.Sprint6.Task6.V22\bin\Debug\InPutFileTask6V22.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = " MLgyapd kEPQzl IOuDWll TMRyztkPxzEVkcarVMlQ unwTmf ";
            Assert.AreEqual(wait, res);
        }
    }
}