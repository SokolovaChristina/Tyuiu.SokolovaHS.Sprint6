using Tyuiu.SokolovaHS.Sprint6.Task1.V12.Lib;
using System;
using System.Windows.Forms;

namespace Tyuiu.SokolovaHS.Sprint6.Task1.V12
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonDone_HSH_Click(object sender, EventArgs e)
        {
            try
            {

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

                // Очищаем поле результата
                buttonResult_HSH.Text = "";

                // Строим таблицу
                buttonResult_HSH.AppendText("+----------+----------+" + Environment.NewLine);
                buttonResult_HSH.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                buttonResult_HSH.AppendText("+----------+----------+" + Environment.NewLine);

                int currentX = startStep;
                for (int i = 0; i < valueArray.Length; i++)
                {
                    string strLine = String.Format("| {0,5} | {1,8:F2} |", currentX, valueArray[i]);
                    buttonResult_HSH.AppendText(strLine + Environment.NewLine);
                    currentX++;
                }

                buttonResult_HSH.AppendText("+----------+----------+" + Environment.NewLine);
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