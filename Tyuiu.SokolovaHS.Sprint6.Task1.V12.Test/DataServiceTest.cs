using Tyuiu.SokolovaHS.Sprint6.Task1.V12.Lib;

namespace Tyuiu.SokolovaIS.Sprint6.Task1.V12.Test
{
    public class DataServiceTest
    {
        private readonly DataService ds = new DataService();

        public void GetMassFunctionTest()
        {
            double[] result = ds.GetMassFunction(-5, 5);

            // Проверяем длину массива
            Assert.Equals(11, result.Length);

            // Проверяем несколько ключевых значений
            Assert.Equals(-8.72, result[0]);   // x=-5
            Assert.Equals(0.00, result[7]);    // x=2 (деление на ноль)
            Assert.Equals(10.58, result[10]);  // x=5
        }

        
        public void DivisionByZeroReturnsZero()
        {
            double[] result = ds.GetMassFunction(2, 2);
            Assert.Equals(0.00, result[0]);
        }
    }
}

