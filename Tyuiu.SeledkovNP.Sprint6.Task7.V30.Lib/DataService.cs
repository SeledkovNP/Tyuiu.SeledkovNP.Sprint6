using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SeledkovNP.Sprint6.Task7.V30.Lib
{
    public class DataService : ISprint6Task7V30
    {
        

        public int[,] GetMatrix(string path)
        {
            int rows = 0;
            int cols = 0;

            // Считываем данные из файла по пути path
            // В реальном случае нужно добавить соответствующий код для чтения данных
            // Здесь предполагается, что данные уже считаны и доступны в матрице matrix
            int[,] matrix = new int[rows, cols]; // Инициализация матрицы

            // Пример чтения данных из файла (псевдокод)
            // string[] lines = File.ReadAllLines(path);
            // for (int i = 0; i < lines.Length; i++)
            // {
            //     string[] cells = lines[i].Split(','); // Разделение на столбцы
            //     for (int j = 0; j < cells.Length; j++)
            //     {
            //         matrix[i, j] = int.Parse(cells[j]); // Преобразование строки в int
            //     }
            // }

            // Обработка матрицы 
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, 0] != 4)
                {
                    matrix[i, 0] = 8;
                }
            }

            return matrix;


            /*
             public int[,] GetMatrix(int[,] matrix)
        {
           
            int rows = matrix.GetLength(0);
            //int cols = matrix.GetLength(1);


            for (int i = 0; i < rows; i++)
            {

                if (matrix[i, 0] != 4)
                {
                    matrix[i, 0] = 8;
                }

            }
            return matrix;
            */

        }
        
    }
}
