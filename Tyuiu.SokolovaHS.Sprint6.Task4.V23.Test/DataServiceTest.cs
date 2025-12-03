using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SokolovaHS.Sprint6.Task4.V23.Lib;

namespace Tyuiu.SokolovaHS.Sprint6.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = new double[11];

            // Рассчитываем ожидаемые значения
            wait[0] = Math.Round(4 - 2 * (-5) + ((2 + Math.Cos(-5)) / (2 * (-5) - 2)), 2);
            wait[1] = Math.Round(4 - 2 * (-4) + ((2 + Math.Cos(-4)) / (2 * (-4) - 2)), 2);
            wait[2] = Math.Round(4 - 2 * (-3) + ((2 + Math.Cos(-3)) / (2 * (-3) - 2)), 2);
            wait[3] = Math.Round(4 - 2 * (-2) + ((2 + Math.Cos(-2)) / (2 * (-2) - 2)), 2);
            wait[4] = Math.Round(4 - 2 * (-1) + ((2 + Math.Cos(-1)) / (2 * (-1) - 2)), 2);
            wait[5] = 0; // x = 0: 2*0-2 = -2 (не ноль) - это ошибка! Проверим:
            wait[5] = Math.Round(4 - 2 * 0 + ((2 + Math.Cos(0)) / (2 * 0 - 2)), 2);
            wait[6] = 0; // x = 1: деление на ноль
            wait[7] = Math.Round(4 - 2 * 2 + ((2 + Math.Cos(2)) / (2 * 2 - 2)), 2);
            wait[8] = Math.Round(4 - 2 * 3 + ((2 + Math.Cos(3)) / (2 * 3 - 2)), 2);
            wait[9] = Math.Round(4 - 2 * 4 + ((2 + Math.Cos(4)) / (2 * 4 - 2)), 2);
            wait[10] = Math.Round(4 - 2 * 5 + ((2 + Math.Cos(5)) / (2 * 5 - 2)), 2);

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidDivisionByZero()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 1;
            double[] res = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(0, res[0]);
        }
    }
}
