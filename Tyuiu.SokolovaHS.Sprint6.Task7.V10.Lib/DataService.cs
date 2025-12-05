using System;
using System.IO;
using System.Collections.Generic;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SokolovaHS.Sprint6.Task7.V10.Lib
{
    public class DataService : ISprint6Task7V10
    {
        public int[,] GetMatrix(string path)
        {
            // Читаем все строки файла
            string[] allLines = File.ReadAllLines(path);

            // Фильтруем пустые строки
            List<string> lines = new List<string>();
            foreach (string line in allLines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    lines.Add(line);
                }
            }

            if (lines.Count == 0)
            {
                return new int[0, 0]; // Возвращаем пустую матрицу
            }

            // Определяем размеры матрицы по первой непустой строке
            int rows = lines.Count;
            int columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            // Заполняем матрицу
            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    // Проверяем, что столбец существует
                    if (j < values.Length && !string.IsNullOrWhiteSpace(values[j]))
                    {
                        matrix[i, j] = int.Parse(values[j].Trim());
                    }
                    else
                    {
                        matrix[i, j] = 0; // значение по умолчанию
                    }
                }
            }

            // Проверяем, что есть хотя бы 5 строк
            if (rows >= 5)
            {
                // Изменяем 5-ю строку (индекс 4): значения от 5 до 10 включительно заменяем на 0
                for (int j = 0; j < columns; j++)
                {
                    int value = matrix[4, j];
                    if (value >= 5 && value <= 10)
                    {
                        matrix[4, j] = 0;
                    }
                }
            }

            return matrix;
        }
    }
}