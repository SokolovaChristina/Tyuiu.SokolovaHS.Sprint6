using Tyuiu.SokolovaHS.Sprint6.Task0.V21.Lib;
namespace Tyuiu.SokolovaHS.Sprint6.Task0.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonVarA_HSH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != 8 && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void buttonDoneProgramm_HSH_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                string inputText = buttonVarA_HSH.Text;

                // 2. Преобразуем в целое число
                int x = Convert.ToInt32(inputText);

                // 3. Вычисляем результат
                double result = ds.Calculate(x);

                // 4. Выводим результат в поле РЕЗУЛЬТАТА (textResultProgramm_HSH)
                // Округляем до 3 знаков после запятой
                textResultProgramm_HSH.Text = result.ToString("F3");

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
