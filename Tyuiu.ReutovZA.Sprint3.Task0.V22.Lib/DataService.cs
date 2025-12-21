using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ReutovZA.Sprint3.Task0.V22.Lib
{
    public class DataService : ISprint3Task0V22
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double res = 1;

            for (int i = startValue; i <= stopValue; i++)
            {
                res *= (Math.Pow(value, i) + 4) * Math.Cos(value);
            }
            return Math.Round(res, 3);
        }
    }
}