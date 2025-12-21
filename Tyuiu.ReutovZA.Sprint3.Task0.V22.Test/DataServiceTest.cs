using Tyuiu.ReutovZA.Sprint3.Task0.V22.Lib;


namespace Tyuiu.ReutovZA.Sprint3.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeriesTest()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int valueStart = 1;
            int valueEnd = 8;
            double res = ds.GetMultiplySeries(value, valueStart, valueEnd);

            double wait = 55217.446;
            Assert.AreEqual(wait, res);
        }
    }
}