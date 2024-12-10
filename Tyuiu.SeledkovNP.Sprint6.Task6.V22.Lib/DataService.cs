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

                // Удаляем начальные и конечные пробельные символы
                string result = input.Trim();

                // Проверяем, есть ли пробелы в начале и в конце
                if (result.StartsWith(" "))
                {
                    // Если первый символ - пробел, удаляем его и следующий за ним символ
                    result = result.Substring(1);
                }

                if (result.EndsWith(" "))
                {
                    // Если последний символ - пробел, удаляем его и предыдущий символ
                    result = result.Substring(0, result.Length - 1);
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
