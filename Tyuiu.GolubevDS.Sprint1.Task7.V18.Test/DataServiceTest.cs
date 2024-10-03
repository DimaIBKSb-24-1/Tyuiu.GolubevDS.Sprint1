namespace Tyuiu.GolubevDS.Sprint1.Task7.V18.Test;
using Tyuiu.GolubevDS.Sprint1.Task7.V18.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        double x = 1;
        double y = 2;
        double z = 5.51;
        var res = ds.Calculate(x,y);
        Assert.AreEqual(z,res);
    }
}