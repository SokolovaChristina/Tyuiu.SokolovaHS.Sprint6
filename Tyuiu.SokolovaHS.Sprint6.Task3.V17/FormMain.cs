using Tyuiu.SokolovaHS.Sprint6.Task3.V17.Lib;
namespace Tyuiu.SokolovaHS.Sprint6.Task3.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] {
            { 22, 32, -16, 24, 27 },
            { 3, -20, 24, -20, 25 },
            { 21, 17, -8, -19, 17 },
            { 8, 22, 28, 27, 19 },
            { 11, 20, 12, 27, 29 }
        };
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridView_HSH.ColumnCount = 5;
            dataGridView_HSH.RowCount = 5;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView_HSH.Rows[i].Cells[j].Value = mtrx[i, j];
                }
            }
        }

        private void buttonDone_HSH_Click(object sender, EventArgs e)
        {
            int[,] sortedMatrix = ds.Calculate(mtrx);

            // Показываем результат в DataGridView
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView_HSH.Rows[i].Cells[j].Value = sortedMatrix[i, j];
                }
            }

            // Подсвечиваем 4-й столбец
            for (int i = 0; i < 5; i++)
            {
                dataGridView_HSH.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
            }

            // Сохраняем результат для второй кнопки в ее Text
            string resultText = "4-й столбец: ";
            for (int i = 0; i < 5; i++)
            {
                resultText += sortedMatrix[i, 3] + " ";
            }
            buttonResult_HSH.Text = resultText;
        }

        private void buttonResult_HSH_TextChanged(object sender, EventArgs e)
        {
            if (buttonResult_HSH.Text.StartsWith("4-й столбец:"))
            {
                MessageBox.Show(buttonResult_HSH.Text, "Результат сортировки");
            }
        }
    }
}
