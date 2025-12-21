using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ReutovZA.Sprint3.Task1.V14.Lib
{
    public class DataService : ISprint3Task1V14
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            int k = startValue;
            while (k <= stopValue)
            {
                // Формула: (t^k + 1/(k+1)) * cos(t)
                sum += (Math.Pow(value, k) + (1.0 / (k + 1.0))) * Math.Cos(value);
                k++;
            }
            return Math.Round(sum, 3);
        }
    }
}
