namespace Tyuiu.GolubevDS.Sprint1.Task3.V4.Test;
    using Tyuiu.GolubevDS.Sprint1.Task3.V4.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {   
        
            DataService ds = new DataService();
        Assert.AreEqual(ds.PurchaseAmount(2.75, 0.5, 7), 22.75);

    }
}