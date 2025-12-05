using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SokolovaHS.Sprint6.Task6.V2.Lib
{
    public class DataService : ISprint6Task6V2
    {
        public string CollectTextFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string result = "";

            foreach (string line in lines)
            {
                // Разделяем строку на слова по пробелам
                string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Если в строке есть хотя бы 2 слова, берем второе слово
                if (words.Length >= 2)
                {
                    result += words[1] + " ";
                }
            }

            // Убираем последний пробел и возвращаем результат
            return result.Trim();
        }
    }
}
