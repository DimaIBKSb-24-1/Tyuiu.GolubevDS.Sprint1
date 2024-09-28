namespace Tyuiu.GolubevDS.Sprint1.Task4.V25.Test;
using Tyuiu.GolubevDS.Sprint1.Task4.V25.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();

        double a = 1;
        double wait = 0.649;
        var res = ds.Calculate(a);
        Assert.AreEqual(wait, res);
    }
}