using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SokolovaHS.Sprint6.Task4.V23.Lib
{
    public class DataService : ISprint6Task4V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] valueArray = new double[length];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                // Проверка деления на ноль: 2x - 2 = 0
                if (2 * x - 2 == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double numerator = 2 + Math.Cos(x);
                    double denominator = 2 * x - 2;
                    double result = 4 - 2 * x + (numerator / denominator);
                    valueArray[count] = Math.Round(result, 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}
