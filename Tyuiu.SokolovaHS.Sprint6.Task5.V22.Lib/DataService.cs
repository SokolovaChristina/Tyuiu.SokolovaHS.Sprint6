using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SokolovaHS.Sprint6.Task5.V22.Lib
{
    public class DataService : ISprint6Task5V22
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            List<double> numbersGreaterThan5 = new List<double>();

            CultureInfo culture = new CultureInfo("ru-RU");

            for (int i = 0; i < lines.Length; i++)
            {
                double number = Math.Round(double.Parse(lines[i], culture), 3);

                // Добавляем только числа больше 5
                if (number > 5)
                {
                    numbersGreaterThan5.Add(number);
                }
            }

            return numbersGreaterThan5.ToArray();
        }
    }
}