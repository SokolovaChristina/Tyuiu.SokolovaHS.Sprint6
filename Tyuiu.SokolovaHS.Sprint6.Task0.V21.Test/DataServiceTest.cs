using Tyuiu.SokolovaHS.Sprint6.Task0.V21.Lib;
namespace Tyuiu.SokolovaHS.Sprint6.Task0.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            double wait = 13.000;
            double res = ds.Calculate(x);
            Assert.Equals(wait, res);

        }
    }
}
