using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SeledkovNP.Sprint6.Task1.V25.Lib
{
    public class DataService : ISprint6Task1V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] output = new double[stopValue - startValue + 1];
            for (int x = startValue; x <= stopValue; x++)
            {
                double result = Math.Round((5 * x + 2.5) / (Math.Sin(x) - 2) + 2, 2);
                if (!double.IsNaN(result))
                {
                    output[x - startValue] = result;
                }
                else
                {
                    output[x - startValue] = 0;
                }
            }

            return output;
        }
    }
}
