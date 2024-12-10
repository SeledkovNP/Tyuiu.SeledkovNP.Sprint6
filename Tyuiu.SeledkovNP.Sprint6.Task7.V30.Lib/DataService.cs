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
            int[,] array = new int[10, 10] { {0 ,19 ,5,   -3 , -1,  -1,  -5,  2,   -16, 3 },
                                           { -8 , -13, -18, 4 ,  -10 ,-15 ,19 , -13, 19 , 14 },
                                            { -6 , 8,   -18, -18 ,-7 , 1 ,  -14, -9,  18,  -9 },
                                            {-19 ,20 , -9  ,20 , -19, 11,  12,  -15, 1,   1 },
                                            {9  , 1  , 13 , 10 , -13 ,-11 ,20,  -17, -8 , 18 } ,
                                            { -5 , -18 ,4  , 1  , 10 , -1 , -11, -18 ,6 ,  11},
                                            {5  , -5 , -16 ,-10 ,-6 , 4 ,  17 , 15 , -12, -10 } ,
                                            { 11 , -16 ,10 , 17,  -18 ,-6 , -20 ,14 , 3 ,  14 },
                                            { -15, -18, 15,  6  , -2 , -3 , 1,   -6 , -7,  -11},
                                           {4  , 3,   -7 , -18, 8 ,  7 ,  5,   18,  20,  2 } }; // Пример матрицы для тестирования
            return array;
        }
    }
}
