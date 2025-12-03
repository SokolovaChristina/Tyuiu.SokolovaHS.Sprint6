using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SokolovaHS.Sprint6.Task5.V22.Lib
{
    public class DataService : ISprint6Task5V22
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            double[] numbers = new double[lines.Length];

            // Используем инвариантную культуру с точкой как разделителем
            CultureInfo culture = CultureInfo.InvariantCulture;

            for (int i = 0; i < lines.Length; i++)
            {
                // Заменяем запятую на точку
                string line = lines[i].Replace(',', '.');
                numbers[i] = Math.Round(double.Parse(line, culture), 3);
            }

            return numbers;
        }
    }
}