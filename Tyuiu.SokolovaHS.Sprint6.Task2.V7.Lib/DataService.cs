using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SokolovaHS.Sprint6.Task2.V7.Lib
{
    public class DataService : ISprint6Task2V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Проверяем корректность диапазона
            if (startValue > stopValue)
            {
                throw new ArgumentException("Начальное значение не может быть больше конечного");
            }

            // Вычисляем размер массива
            int length = stopValue - startValue + 1;
            double[] resultArray = new double[length];

            // Табулируем функцию
            for (int i = 0; i < length; i++)
            {
                int x = startValue + i;
                resultArray[i] = CalculateFunction(x);
            }

            return resultArray;
        }

        /// <summary>
        /// Вычисляет значение функции F(x) = 3x + 2 - (2x - x)/(cos(x) + 1)
        /// Упрощаем: 2x - x = x, поэтому F(x) = 3x + 2 - x/(cos(x) + 1)
        /// </summary>
        private double CalculateFunction(int x)
        {
            // Проверка деления на ноль: cos(x) + 1 = 0
            double cosX = Math.Cos(x);
            double denominator = cosX + 1;

            // Если знаменатель равен нулю (с учетом погрешности double)
            if (Math.Abs(denominator) < 0.0000001)
            {
                return 0; // При делении на ноль возвращаем 0
            }

            // Вычисляем значение функции
            // F(x) = 3x + 2 - (2x - x)/(cos(x) + 1) = 3x + 2 - x/(cos(x) + 1)
            double numerator = (2 * x) - x; // Это просто x
            double fraction = numerator / denominator;
            double result = (3 * x) + 2 - fraction;

            // Округляем до двух знаков после запятой
            return Math.Round(result, 2);
        }
    }
}
