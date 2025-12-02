using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SokolovaHS.Sprint6.Task1.V12.Lib
{
    public class DataService : ISprint6Task1V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Вычисляем количество элементов в массиве
            int length = Math.Abs(stopValue - startValue) + 1;
            double[] resultArray = new double[length];

            int index = 0;

            // Табулируем функцию на заданном диапазоне
            for (int x = startValue; x <= stopValue; x++)
            {
                // Вычисляем значение функции F(x) = sin(x) + (cos(x)+1)/(2-x) + 2x
                // С проверкой деления на ноль (при x = 2)

                double sinX = Math.Sin(x);
                double cosX = Math.Cos(x);

                // Проверяем деление на ноль
                if (x == 2)
                {
                    // При делении на ноль возвращаем 0 согласно условию
                    resultArray[index] = 0;
                }
                else
                {
                    double fraction = (cosX + 1) / (2 - x);
                    double functionValue = sinX + fraction + 2 * x;

                    // Округляем до двух знаков после запятой
                    resultArray[index] = Math.Round(functionValue, 2);
                }

                index++;
            }

            return resultArray;
        }
    }
}
