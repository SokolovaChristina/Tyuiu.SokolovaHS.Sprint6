using Tyuiu.SokolovaHS.Sprint6.Task1.V12.Lib;

namespace Tyuiu.SokolovaIS.Sprint6.Task1.V12.Test
{
    public class DataServiceTest
    {
        private readonly DataService ds = new DataService();

        public void GetMassFunctionTest()
        {
            double[] result = ds.GetMassFunction(-5, 5);

            
            Assert.Equals(11, result.Length);

            
            Assert.Equals(-8.72, result[0]);   
            Assert.Equals(0.00, result[7]);    
            Assert.Equals(10.58, result[10]);  
        }

        
        public void DivisionByZeroReturnsZero()
        {
            double[] result = ds.GetMassFunction(2, 2);
            Assert.Equals(0.00, result[0]);
        }
    }
}

