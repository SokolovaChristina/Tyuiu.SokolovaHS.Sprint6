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

            // Сортируем строки по 4-му столбцу (индекс 3) по возрастанию
            // Используем сортировку пузырьком для строк
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    // Сравниваем значения в 4-м столбце
                    if (resultMatrix[j, 3] > resultMatrix[j + 1, 3])
                    {
                        // Меняем строки местами
                        SwapRows(resultMatrix, j, j + 1);
                    }
                }
            }

            return resultMatrix;
        }

        /// <summary>
        /// Меняет две строки матрицы местами
        /// </summary>
        private void SwapRows(int[,] matrix, int row1, int row2)
        {
            int cols = matrix.GetLength(1);

            for (int col = 0; col < cols; col++)
            {
                int temp = matrix[row1, col];
                matrix[row1, col] = matrix[row2, col];
                matrix[row2, col] = temp;
            }
        }
    }
}
        
    

