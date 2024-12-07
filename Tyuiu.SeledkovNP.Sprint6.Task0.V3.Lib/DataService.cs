using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SeledkovNP.Sprint6.Task0.V3.Lib
{
    public class DataService : ISprint6Task0V3
    {
        public double Calculate(int x)
        {
            // 4x'3
            // --------
            //   x'3 -1


            double numerator = 4 * Math.Pow(x, 3);   // верх
            double denominator = Math.Pow(x, 3) - 1; // Вниз
            double res = numerator / denominator;    //Готовый ответ
            return Math.Round(res, 3);
        }
    }
}
