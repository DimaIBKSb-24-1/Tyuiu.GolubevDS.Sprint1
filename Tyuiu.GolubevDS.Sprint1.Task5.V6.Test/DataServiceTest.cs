namespace Tyuiu.GolubevDS.Sprint1.Task5.V6.Test;
using Tyuiu.GolubevDS.Sprint1.Task5.V6.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        int n, k = 1;
        var res = ds.Calculate(k);
        Assert.AreEqual(1, res);
    }
}