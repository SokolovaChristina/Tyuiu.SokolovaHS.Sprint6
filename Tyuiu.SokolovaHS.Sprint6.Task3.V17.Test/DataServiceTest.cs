using Tyuiu.SokolovaHS.Sprint6.Task3.V17.Lib;
namespace Tyuiu.SokolovaHS.Sprint6.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            // Матрица из задания
            int[,] matrix = {
                { 22, 32, -16, 24, 27 },
                { 3, -20, 24, -20, 25 },
                { 21, 17, -8, -19, 17 },
                { 8, 22, 28, 27, 19 },
                { 11, 20, 12, 27, 29 }
            };

            // Act
            int[,] result = ds.Calculate(matrix);

            // Assert
            // После сортировки по 4-му столбцу (индекс 3):
            // Строки должны быть в порядке: 1, 2, 0, 3, 4
            // (по значениям в 4-м столбце: -20, -19, 24, 27, 27)

            // Проверяем порядок значений в 4-м столбце
            Assert.Equals(-20, result[0, 3]); // Первая строка после сортировки
            Assert.Equals(-19, result[1, 3]); // Вторая строка
            Assert.Equals(24, result[2, 3]);  // Третья строка
            Assert.Equals(27, result[3, 3]);  // Четвертая строка
            Assert.Equals(27, result[4, 3]);  // Пятая строка

            // Проверяем, что вся строка сохраняется
            // Для первой строки (бывшая строка 1):
            Assert.Equals(3, result[0, 0]);   // Значение из исходной строки 1
            Assert.Equals(-20, result[0, 1]);
            Assert.Equals(24, result[0, 2]);
            Assert.Equals(-20, result[0, 3]); // Столбец сортировки
            Assert.Equals(25, result[0, 4]);

            // Проверяем размеры матрицы
            Assert.Equals(5, result.GetLength(0));
            Assert.Equals(5, result.GetLength(1));
        }

        
        public void NullMatrix_ThrowsException()
        {
            // Arrange
            DataService ds = new DataService();

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => ds.Calculate(null));
        }

        
        public void InvalidMatrixSize_ThrowsException()
        {
            // Arrange
            DataService ds = new DataService();
            int[,] wrongSizeMatrix = new int[3, 3];

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => ds.Calculate(wrongSizeMatrix));
        }

        
        public void AlreadySortedMatrix_ReturnsSameOrder()
        {
            // Arrange
            DataService ds = new DataService();

            // Матрица уже отсортирована по 4-му столбцу
            int[,] matrix = {
                { 1, 2, 3, 10, 5 },
                { 6, 7, 8, 20, 10 },
                { 11, 12, 13, 30, 15 },
                { 16, 17, 18, 40, 20 },
                { 21, 22, 23, 50, 25 }
            };

            // Act
            int[,] result = ds.Calculate(matrix);

            // Assert - порядок должен сохраниться
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.Equals(matrix[i, j], result[i, j]);
                }
            }
        }
    }
}
        
    

