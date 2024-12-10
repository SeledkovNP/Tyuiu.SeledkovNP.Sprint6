using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SeledkovNP.Sprint6.Task7.V30.Lib
{
    public class DataService : ISprint6Task7V30
    {


        public int[,] GetMatrix(string path)
        {
            // Предполагается, что здесь матрица загружается из файла
            int[,] matrix = LoadMatrixFromFile(path);

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, 0] != 4)
                {
                    matrix[i, 0] = 8;
                }
            }

            return matrix;
        }
        private int[,] LoadMatrixFromFile(string path)
        {
            // Здесь должен быть код для чтения данных из файла по указанному пути
            int[,] matrix = { { 1, 2 }, { 3, 4 }, { 5, 6 } }; // Пример матрицы для тестирования
            return matrix;
        }
    }
}
