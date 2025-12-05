using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SokolovaHS.Sprint6.Task7.V10.Lib;
using System.IO;

namespace Tyuiu.SokolovaHS.Sprint6.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            // Создаем временный CSV файл
            string path = @"C:\Temp\TestMatrix.csv";

            // Тестовые данные матрицы 3x3
            string[] testData = {
                "1;2;3",
                "4;5;6",
                "7;8;9"
            };

            File.WriteAllLines(path, testData);

            // Вызываем метод
            int[,] res = ds.GetMatrix(path);

            // Проверяем размеры
            Assert.AreEqual(3, res.GetLength(0));
            Assert.AreEqual(3, res.GetLength(1));

            // Проверяем значения (5-я строка не меняется, так как матрица 3x3)
            Assert.AreEqual(1, res[0, 0]);
            Assert.AreEqual(5, res[1, 1]);
            Assert.AreEqual(9, res[2, 2]);

            File.Delete(path);
        }

        [TestMethod]
        public void ValidFifthRowModification()
        {
            DataService ds = new DataService();

            string path = @"C:\Temp\TestFifthRow.csv";

            // Матрица минимум 5 строк
            string[] testData = {
                "1;2;3;4;5",
                "6;7;8;9;10",
                "11;12;13;14;15",
                "16;17;18;19;20",
                "5;6;7;8;9"  // 5-я строка: 5,6,7,8,9 (все в диапазоне 5-10)
            };

            File.WriteAllLines(path, testData);

            int[,] res = ds.GetMatrix(path);

            // Проверяем, что 5-я строка (индекс 4) изменена на 0
            Assert.AreEqual(0, res[4, 0]); // 5 → 0
            Assert.AreEqual(0, res[4, 1]); // 6 → 0
            Assert.AreEqual(0, res[4, 2]); // 7 → 0
            Assert.AreEqual(0, res[4, 3]); // 8 → 0
            Assert.AreEqual(0, res[4, 4]); // 9 → 0

            // Другие строки не изменились
            Assert.AreEqual(1, res[0, 0]);
            Assert.AreEqual(7, res[1, 1]);
            Assert.AreEqual(13, res[2, 2]);
            Assert.AreEqual(19, res[3, 3]);

            File.Delete(path);
        }

        [TestMethod]
        public void ValidPartialModification()
        {
            DataService ds = new DataService();

            string path = @"C:\Temp\TestPartial.csv";

            string[] testData = {
                "1;2;3",
                "4;5;6",
                "7;8;9",
                "10;11;12",
                "3;5;12"  // 5-я строка: 3,5,12 (только 5 в диапазоне 5-10)
            };

            File.WriteAllLines(path, testData);

            int[,] res = ds.GetMatrix(path);

            // Проверяем частичное изменение 5-й строки
            Assert.AreEqual(3, res[4, 0]); // 3 не меняется
            Assert.AreEqual(0, res[4, 1]); // 5 → 0
            Assert.AreEqual(12, res[4, 2]); // 12 не меняется

            File.Delete(path);
        }
    }
}
