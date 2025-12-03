using Tyuiu.SokolovaHS.Sprint6.Task4.V23.Lib;
namespace Tyuiu.SokolovaHS.Sprint6.Task4.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_HSH_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем диапазон от пользователя
                int StartStep_HSH = -5; // можно заменить на textBox значение
                int StopStep_HSH = 5;   // можно заменить на textBox значение

                // Получаем значения функции через библиотеку
                double[] functionValues = ds.GetMassFunction(StartStep_HSH, StopStep_HSH);

                // Выводим результат в кнопку buttonResult_HSH
                string result = $"Диапазон: [{StartStep_HSH}; {StopStep_HSH}]\r\n\r\n";
                for (int i = 0, x = StartStep_HSH; x <= StopStep_HSH; x++, i++)
                {
                    result += $"F({x}) = {functionValues[i]:F2}\r\n";
                }
                buttonResult_HSH.Text = result;

                // Строим график
                //chartFunction_HSH.Series[0].Points.Clear();
                //for (int i = 0, x = StartStep_HSH; x <= StopStep_HSH; x++, i++)
                //{
                //    chartFunction_HSH.Series[0].Points.AddXY(x, functionValues[i]);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_HSH_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"OutPutFileTask4V23.txt";

                // Сохраняем текст из кнопки buttonResult_HSH
                File.WriteAllText(path, buttonResult_HSH.Text);

                MessageBox.Show($"Файл сохранен: {path}", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
