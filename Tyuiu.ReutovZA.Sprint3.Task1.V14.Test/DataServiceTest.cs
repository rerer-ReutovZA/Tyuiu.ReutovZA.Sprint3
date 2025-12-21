using Tyuiu.ReutovZA.Sprint3.Task1.V14.Lib;

namespace Tyuiu.ReutovZA.Sprint3.Task1.V14.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetSumSeries()
    {
        DataService ds = new DataService();
        double t = 0.7;
        int start = 1;
        int stop = 14;
        double res = ds.GetSumSeries(t, start, stop);

        // Ожидаемое значение для t=0.7 при k от 1 до 14
        Assert.AreEqual(3.546, res);
    }
}