namespace Tyuiu.GolubevDS.Sprint1.Task1.V19.Test;
using Tyuiu.GolubevDS.Sprint1.Task1.V19.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds =new DataService();
        double x = 1;
        double y = 2;
        var res = ds.Calculate(x, y);
        Assert.AreEqual(10,5, res);
    }
}