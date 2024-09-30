namespace Tyuiu.GolubevDS.Sprint1.Task6.V5.Test;
using Tyuiu.GolubevDS.Sprint1.Task6.V5.Lib;
[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidString()
    {
        DataService ds = new DataService();
        string text = "казак дом шалаш машина";
        string res = ds.CheckSymmetricalWords(text);
        Assert.AreEqual("казак, шалаш", res);
    }
}
