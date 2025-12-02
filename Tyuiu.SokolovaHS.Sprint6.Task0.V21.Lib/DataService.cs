using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SokolovaHS.Sprint6.Task0.V21.Lib
{
    public class DataService : ISprint6Task0V21
    {
        public double Calculate(int x)
        {
            x = Convert.ToInt32(x);
            double result = ((2 * Math.Pow(x, 3)) + (0.5 * Math.Pow(x, 2)) - (3.5 * x) + 2);
            return Math.Round(result, 3);
        }
    }
}
