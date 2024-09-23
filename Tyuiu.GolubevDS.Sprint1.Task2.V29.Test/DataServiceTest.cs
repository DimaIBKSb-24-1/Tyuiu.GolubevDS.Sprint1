namespace Tyuiu.GolubevDS.Sprint1.Task2.V29.Test;
using Tyuiu.GolubevDS.Sprint1.Task2.V29.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpresion()
    {
        DataService ds = new DataService();
      
        Assert.AreEqual(2, ds.ConvertSecondsToHours(120));
    }
}