using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SokolovaHS.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Создаем копию матрицы
            int[,] resultMatrix = (int[,])matrix.Clone();

            // Собираем значения 4-го столбца
            int[] fourthColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                fourthColumn[i] = resultMatrix[i, 3];
            }

            // Сортируем только значения 4-го столбца (без изменения строк)
            Array.Sort(fourthColumn);

            // Записываем отсортированные значения обратно в 4-й столбец
            for (int i = 0; i < rows; i++)
            {
                resultMatrix[i, 3] = fourthColumn[i];
            }

            return resultMatrix;
        }
    }
}