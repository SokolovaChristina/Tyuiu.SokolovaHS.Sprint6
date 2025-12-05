using Tyuiu.SokolovaHS.Sprint6.Task7.V10.Lib;
namespace Tyuiu.SokolovaHS.Sprint6.Task7.V10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] modifiedMatrix;
        private void buttonDone_HSH_Click(object sender, EventArgs e)
        {
            try
            {
                // Открываем файл
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                    openFileDialog.Title = "Выберите CSV файл";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = openFileDialog.FileName;

                        // Читаем и обрабатываем матрицу через библиотеку
                        modifiedMatrix = ds.GetMatrix(path);

                        // Выводим информацию о результате в кнопку buttonResult_HSH
                        string resultText = "Обработанная матрица:\n";
                        int rows = modifiedMatrix.GetLength(0);
                        int cols = modifiedMatrix.GetLength(1);

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < cols; j++)
                            {
                                resultText += $"{modifiedMatrix[i, j],4}";
                                if (j < cols - 1) resultText += ";";
                            }
                            resultText += "\n";
                        }

                        buttonResult_HSH.Text = resultText;

                        // Сохраняем результат в файл автоматически
                        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                        {
                            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                            saveFileDialog.Title = "Сохранить результат";
                            saveFileDialog.FileName = "OutPutFileTask7.csv";

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                string savePath = saveFileDialog.FileName;

                                // Сохраняем матрицу в файл
                                using (StreamWriter writer = new StreamWriter(savePath))
                                {
                                    for (int i = 0; i < rows; i++)
                                    {
                                        for (int j = 0; j < cols; j++)
                                        {
                                            writer.Write(modifiedMatrix[i, j]);
                                            if (j < cols - 1) writer.Write(";");
                                        }
                                        writer.WriteLine();
                                    }
                                }

                                MessageBox.Show($"Файл сохранен: {savePath}", "Успех",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonResult_HSH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
