using Tyuiu.SokolovaHS.Sprint6.Task2.V7.Lib;
using System;
using System.Windows.Forms;

namespace Tyuiu.SokolovaHS.Sprint6.Task2.V7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_SHS_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем значения из TextBox (не из Button!)
                // Предполагаю, что buttonStartStep_HSH и buttonStopStep_HSH - это TextBox
                int startStep = Convert.ToInt32(buttonStartStep_HSH.Text);
                int stopStep = Convert.ToInt32(buttonStopStep_HSH.Text);

                // Проверка диапазона
                if (startStep > stopStep)
                {
                    MessageBox.Show("Начальное значение не может быть больше конечного",
                                  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Получаем массив значений
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                // Очищаем DataGridView
                buttonResult_HSH.Rows.Clear();

                // Настраиваем колонки, если их еще нет
                if (buttonResult_HSH.Columns.Count == 0)
                {
                    buttonResult_HSH.Columns.Add("ColumnX", "X");
                    buttonResult_HSH.Columns.Add("ColumnFX", "F(x)");

                    // Настраиваем ширину колонок
                    buttonResult_HSH.Columns["ColumnX"].Width = 80;
                    buttonResult_HSH.Columns["ColumnFX"].Width = 100;

                    // Настраиваем выравнивание
                    buttonResult_HSH.Columns["ColumnX"].DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;
                    buttonResult_HSH.Columns["ColumnFX"].DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;

                    // Форматирование для чисел
                    buttonResult_HSH.Columns["ColumnFX"].DefaultCellStyle.Format = "F2";
                }

                // Добавляем строки в DataGridView
                int currentX = startStep;
                for (int i = 0; i < valueArray.Length; i++)
                {
                    // Добавляем новую строку с данными
                    buttonResult_HSH.Rows.Add(currentX, valueArray[i].ToString("F2"));
                    currentX++;
                }

                // ИЛИ через index (альтернативный способ):
                // for (int i = 0; i < valueArray.Length; i++)
                // {
                //     int index = buttonResult_HSH.Rows.Add();
                //     buttonResult_HSH.Rows[index].Cells[0].Value = startStep + i;
                //     buttonResult_HSH.Rows[index].Cells[1].Value = valueArray[i].ToString("F2");
                // }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите целые числа в поля X",
                              "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}