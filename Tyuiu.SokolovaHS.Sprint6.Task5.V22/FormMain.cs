using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Tyuiu.SokolovaHS.Sprint6.Task5.V22.Lib;

namespace Tyuiu.SokolovaHS.Sprint6.Task5.V22
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();
        private double[] numbersArray;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_HSH_Click(object sender, EventArgs e)
        {
            try
            {
                // Путь к файлу
                string path = @"C:\DataSprint6\InPutDataFileTask5V22.txt";

                // Загружаем данные из файла через библиотеку
                numbersArray = ds.LoadFromDataFile(path);

                // Настраиваем DataGridView
                dataGridViewResult_HSH.Columns.Clear();
                dataGridViewResult_HSH.Columns.Add("columnIndex", "№");
                dataGridViewResult_HSH.Columns.Add("columnValue", "Значение");
                dataGridViewResult_HSH.Columns.Add("columnGreaterThan5", "> 5?");
                dataGridViewResult_HSH.Rows.Clear();

                // Выводим все 20 чисел
                for (int i = 0; i < numbersArray.Length; i++)
                {
                    dataGridViewResult_HSH.Rows.Add(
                        i + 1,
                        numbersArray[i].ToString("F3"),
                        numbersArray[i] > 5 ? "Да" : "Нет"
                    );
                }

                // Строим диаграмму для чисел больше 5
                buttonDone_HSH.Text = "Выполнено";
                buttonDone_HSH.Enabled = false;

                // Используем кнопку для вывода информации
                string info = "Числа > 5:\n";
                for (int i = 0; i < numbersArray.Length; i++)
                {
                    if (numbersArray[i] > 5)
                    {
                        info += $"{numbersArray[i]:F3}\n";
                    }
                }
                buttonDone_HSH.Text = info;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}