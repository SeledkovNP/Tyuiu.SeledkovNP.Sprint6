using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SeledkovNP.Sprint6.Task2.V27.Lib
{
    public class DataService : ISprint6Task2V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int index = 0;
            double[] mass = new double[stopValue - startValue + 1];
            for (int i = startValue; i <= stopValue; i++)
            {
                if (Math.Cos(i) - 2d * (double)i == 0)
                {
                    mass[index] = 0;
                }
                else
                {
                    mass[index] = Math.Round((2d * (double)i - 3d) / (Math.Cos(i) - 2d * (double)i) + 5d * (double)i - Math.Sin(i), 2);
                }
                index++;
            }
            return mass;
        }
    }
}
