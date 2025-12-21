using Tyuiu.ReutovZA.Sprint3.Task7.V24.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetMassFunction()
    {
        DataService ds = new DataService();

        int startValue = -5;
        int stopValue = 5;

        int len = stopValue - startValue + 1;

        double[] valueWaitArray;
        valueWaitArray = new double[len];

        valueWaitArray[] = 7.83;
        valueWaitArray[] = ;
        valueWaitArray[] = ;
        valueWaitArray[] = ;
        valueWaitArray[] = ;

        double[] res;
        res = new double[len];
        res = ds.GetMassFunction(startValue, stopValue);
        CollectionAssert.AreEqual(valueWaitArray, res);
    }
}
//  7,83  |
// -4 | 6,22 |
//| -3 | 6,36 |
//| -2 | 6,96 |
//| -1 | -0,52 |
//| 0 | 0,00 |
//| 1 | -3,30 |
//| 2 | -5,53 |
//| 3 | -6,25 |
//| 4 | -6,63 |
//| 5 | -8,24