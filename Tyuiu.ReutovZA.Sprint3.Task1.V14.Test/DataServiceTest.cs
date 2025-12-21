using Tyuiu.ReutovZA.Sprint3.Task1.V14.Lib;

namespace Tyuiu.ReutovZA.Sprint3.Task1.V14.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        DataService ds = new DataService();
        Assert.That(ds.GetSumSeries(0.7, 1, 14), Is.EqualTo(3.546));
    }
}