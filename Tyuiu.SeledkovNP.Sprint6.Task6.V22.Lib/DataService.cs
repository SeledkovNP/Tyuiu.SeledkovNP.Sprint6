using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SeledkovNP.Sprint6.Task6.V22.Lib
{
    public class DataService : ISprint6Task6V22
    {
       

        public string CollectTextFromFile(string path)
        {

           
                string resStr = "";
                using (StreamReader reader = new StreamReader(path))
                {
                    
                    string line ;
                
                    while ((line = reader.ReadLine()) != null)
                    {
                    resStr += " " + line.Split(' ')[0];
                    path = resStr;

                    }
                }
                return path;


            /*
             
             public string CollectTextFromFile(string str, string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    resStr += " " + line.Split(' ')[0];
                }
            }
            return resStr;
        }

             */



        }
    }
}
