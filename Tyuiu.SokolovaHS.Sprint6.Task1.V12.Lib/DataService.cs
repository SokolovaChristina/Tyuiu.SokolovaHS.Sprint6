using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SokolovaHS.Sprint6.Task1.V12.Lib
{
    public class DataService : ISprint6Task1V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            
            int length = Math.Abs(stopValue - startValue) + 1;
            double[] resultArray = new double[length];

            int index = 0;

          
            for (int x = startValue; x <= stopValue; x++)
            {
                

                double sinX = Math.Sin(x);
                double cosX = Math.Cos(x);

                
                if (x == 2)
                {
                    
                    resultArray[index] = 0;
                }
                else
                {
                    double fraction = (cosX + 1) / (2 - x);
                    double functionValue = sinX + fraction + 2 * x;

                    
                    resultArray[index] = Math.Round(functionValue, 2);
                }

                index++;
            }

            return resultArray;
        }
    }
}
