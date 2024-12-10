using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SeledkovNP.Sprint6.Task6.V22.Lib
{
    public class DataService : ISprint6Task6V22
    {

        public string CollectTextFromFile(string path)
        {

                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                    path += " " + line.Split(' ')[0];
                    }
                }
                return path;


        }
    }
}
