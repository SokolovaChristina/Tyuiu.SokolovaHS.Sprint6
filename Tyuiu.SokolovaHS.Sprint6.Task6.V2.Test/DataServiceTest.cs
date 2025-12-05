using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SokolovaHS.Sprint6.Task6.V2.Lib;
using System.IO;

namespace Tyuiu.SokolovaHS.Sprint6.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();

            // Создаем временный файл для тестирования
            string path = @"C:\Temp\TestFileTask6.txt";

            // Тестовые данные
            string[] testData = {
                "EovFJ da WLCdQb mGVUEyeWqYrqAOaI",
                "Vud ijiH W ehWGn qqAAJvRJjfODPAeE",
                "RgdW M QIK HDDYrXH McJC DBjgLMGsdo",
                "KwQBrOM upBSzre lhTKeblSG PbHxb",
                "Ewyq YGVyY viZ FKxGs lLZdQ dXbj ERKy"
            };

            File.WriteAllLines(path, testData);

            // Вызываем метод
            string res = ds.CollectTextFromFile(path);

            // Ожидаемый результат: вторые слова каждой строки через пробел
            // da ijiH M upBSzre YGVyY
            string wait = "da ijiH M upBSzre YGVyY";

            Assert.AreEqual(wait, res);

            // Очищаем временный файл
            File.Delete(path);
        }

        [TestMethod]
        public void ValidEmptyFile()
        {
            DataService ds = new DataService();

            string path = @"C:\Temp\EmptyFile.txt";
            File.WriteAllText(path, "");

            string res = ds.CollectTextFromFile(path);

            Assert.AreEqual("", res);

            File.Delete(path);
        }

        [TestMethod]
        public void ValidSingleWordLines()
        {
            DataService ds = new DataService();

            string path = @"C:\Temp\SingleWord.txt";
            string[] testData = {
                "OneWord",
                "Another",
                "ThirdWord"
            };

            File.WriteAllLines(path, testData);

            string res = ds.CollectTextFromFile(path);

            // Если в строке только одно слово, второе слово не берется
            Assert.AreEqual("", res);

            File.Delete(path);
        }

        [TestMethod]
        public void ValidMixedLines()
        {
            DataService ds = new DataService();

            string path = @"C:\Temp\Mixed.txt";
            string[] testData = {
                "First Second Third",
                "OnlyOne",
                "A B C D",
                "  Multiple   Spaces   ",
                "Last One"
            };

            File.WriteAllLines(path, testData);

            string res = ds.CollectTextFromFile(path);

            // Вторые слова: Second, B, One
            string wait = "Second B One";

            Assert.AreEqual(wait, res);

            File.Delete(path);
        }

        [TestMethod]
        public void ValidFileNotFound()
        {
            DataService ds = new DataService();

            string path = @"C:\Temp\NotExists.txt";

            try
            {
                string res = ds.CollectTextFromFile(path);
                // Если файл не существует, должно возникнуть исключение
                Assert.Fail("Ожидалось исключение FileNotFoundException");
            }
            catch (FileNotFoundException)
            {
                // Это ожидаемое поведение
                Assert.IsTrue(true);
            }
        }
    }
}
