namespace Tyuiu.GolubevDS.Sprint1.Task4.V25.Test;
using Tyuiu.GolubevDS.Sprint1.Task4.V25.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        double a = 120;
        double z = -1.415;
        var res = ds.Calculate(a);
        Assert.AreEqual(z, res);
    }
}