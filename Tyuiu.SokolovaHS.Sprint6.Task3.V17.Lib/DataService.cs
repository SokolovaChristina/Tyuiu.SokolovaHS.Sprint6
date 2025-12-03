using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SokolovaHS.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Создаем копию матрицы, чтобы не изменять оригинал
            int[,] resultMatrix = (int[,])matrix.Clone();

            // Используем стабильную сортировку (сортировка вставками)
            for (int i = 1; i < rows; i++)
            {
                int[] currentRow = new int[cols];
                int currentValue = resultMatrix[i, 3];

                // Копируем текущую строку
                for (int col = 0; col < cols; col++)
                {
                    currentRow[col] = resultMatrix[i, col];
                }

                int j = i - 1;

                // Сдвигаем строки с большими значениями вправо
                while (j >= 0 && resultMatrix[j, 3] > currentValue)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        resultMatrix[j + 1, col] = resultMatrix[j, col];
                    }
                    j--;
                }

                // Вставляем текущую строку на правильное место
                for (int col = 0; col < cols; col++)
                {
                    resultMatrix[j + 1, col] = currentRow[col];
                }
            }

            return resultMatrix;
        }
    }
}