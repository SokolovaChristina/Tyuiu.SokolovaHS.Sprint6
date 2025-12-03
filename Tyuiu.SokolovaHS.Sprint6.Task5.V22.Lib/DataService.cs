using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SokolovaHS.Sprint6.Task5.V22.Lib
{
    public class DataService : ISprint6Task5V22
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            double[] numbers = new double[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                // Заменяем запятую на точку для корректного парсинга
                string line = lines[i].Replace(",", ".");
                numbers[i] = Math.Round(double.Parse(line), 3); // Округляем до 3 знаков
            }

            return numbers;
        }
    }
}
