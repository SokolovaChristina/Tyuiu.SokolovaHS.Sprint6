using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SokolovaHS.Sprint6.Task5.V22.Lib;
using System.IO;

namespace Tyuiu.SokolovaHS.Sprint6.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Создаем временный файл для тестирования
            string path = @"C:\Temp\TestFile.txt";

            // Записываем тестовые данные
            string[] testData = {
                "-17",
                "0",
                "12",
                "-14,32",
                "5",
                "-7,84",
                "12,89",
                "-1,57",
                "-3,64",
                "-13,26",
                "-8,91",
                "-17,77",
                "35",
                "-9",
                "13,83",
                "12,76",
                "8,86",
                "0",
                "-1,49",
                "-7"
            };

            File.WriteAllLines(path, testData);

            // Вызываем метод
            double[] res = ds.LoadFromDataFile(path);

            // Проверяем количество элементов
            Assert.AreEqual(20, res.Length);

            // Проверяем некоторые значения
            Assert.AreEqual(-17, res[0]);
            Assert.AreEqual(0, res[1]);
            Assert.AreEqual(12, res[2]);
            Assert.AreEqual(-14.32, Math.Round(res[3], 2));
            Assert.AreEqual(5, res[4]);
            Assert.AreEqual(-7.84, Math.Round(res[5], 2));

            // Очищаем временный файл
            File.Delete(path);
        }

        [TestMethod]
        public void ValidRounding()
        {
            DataService ds = new DataService();

            string path = @"C:\Temp\TestRounding.txt";

            // Числа с большим количеством знаков
            string[] testData = {
                "3,1415926535",
                "2,7182818284",
                "1,23456789"
            };

            File.WriteAllLines(path, testData);

            double[] res = ds.LoadFromDataFile(path);

            // Проверяем округление до 3 знаков
            Assert.AreEqual(3.142, Math.Round(res[0], 3));
            Assert.AreEqual(2.718, Math.Round(res[1], 3));
            Assert.AreEqual(1.235, Math.Round(res[2], 3));

            File.Delete(path);
        }

        [TestMethod]
        public void ValidEmptyFile()
        {
            DataService ds = new DataService();

            string path = @"C:\Temp\EmptyFile.txt";
            File.WriteAllText(path, "");

            double[] res = ds.LoadFromDataFile(path);

            Assert.AreEqual(0, res.Length);

            File.Delete(path);
        }
    }
}
