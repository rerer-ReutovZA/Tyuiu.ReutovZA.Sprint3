using Tyuiu.ReutovZA.Sprint3.Task4.V4.Lib;

namespace Tyuiu.ReutovZA.Sprint3.Task4.V4.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidDeleteCharFromStr()
    {
        DataService ds = new DataService();
        string str = "plkjjdw cvjkl";
        string res = ds.DeleteCharFromStr(str);

        // Ожидаемый результат: "plkdw cvkl" (все 'j' удалены)
        Assert.AreEqual("plkdw cvkl", res);
    }
}