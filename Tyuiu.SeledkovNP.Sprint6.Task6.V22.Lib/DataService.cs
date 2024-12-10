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
                    

                    }
                
                

                string input = resStr;
                string result = input.Trim();
                if (result.Length > 0)
                {
                    // Находим индексы первого и последнего символа, исключая символы-разделители
                    int startIndex = result.IndexOf(result[0]);
                    int endIndex = result.LastIndexOf(result[result.Length - 1]);

                    // Если символы-разделители не найдены, оставляем всю строку
                    if (startIndex != -1 && endIndex != -1)
                    {
                        result = result.Substring(startIndex + 1, endIndex - startIndex - 1);
                    }
                }
                path = result;

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
