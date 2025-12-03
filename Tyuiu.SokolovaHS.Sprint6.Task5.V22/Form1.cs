using Tyuiu.SokolovaHS.Sprint6.Task5.V22.Lib;
namespace Tyuiu.SokolovaHS.Sprint6.Task5.V22;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    DataService ds = new DataService();
    double[] numbersArray;
    private void dataGridViewResult_HSH_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        
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

            // Используем кнопку для вывода информации
            string info = "Числа > 5:\n";
            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] > 5)
                {
                    info += $"{numbersArray[i]:F3}\n";
                }
            }

            // Меняем текст кнопки
            buttonDone_HSH.Text = "Выполнено";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
