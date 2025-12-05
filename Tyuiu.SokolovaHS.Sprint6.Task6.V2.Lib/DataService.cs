using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SokolovaHS.Sprint6.Task7.V10.Lib
{
    public class DataService : ISprint6Task7V10
    {
        public int[,] GetMatrix(string path)
        {
            // Читаем все строки файла
            string[] lines = File.ReadAllLines(path);

            // Определяем размеры матрицы
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            // Заполняем матрицу
            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            // Изменяем 5-ю строку (индекс 4): значения от 5 до 10 включительно заменяем на 0
            for (int j = 0; j < columns; j++)
            {
                int value = matrix[4, j];
                if (value >= 5 && value <= 10)
                {
                    matrix[4, j] = 0;
                }
            }

            return matrix;
        }
    }
}