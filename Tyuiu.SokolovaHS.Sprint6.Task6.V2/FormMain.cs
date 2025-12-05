using Tyuiu.SokolovaHS.Sprint6.Task6.V2.Lib;
namespace Tyuiu.SokolovaHS.Sprint6.Task6.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string filePath = "";
        private void buttonDone_HSH_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем OpenFileDialog
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                    openFileDialog.Title = "Выберите файл";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;

                        // Выполняем алгоритм через библиотеку
                        string result = ds.CollectTextFromFile(filePath);

                        // Выводим результат в textBoxOut_HSH
                        textBoxOut_HSH.Text = result;
                    }
                    else
                    {
                        MessageBox.Show("Файл не выбран", "Информация",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
