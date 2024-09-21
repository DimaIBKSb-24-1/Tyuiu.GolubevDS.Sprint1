namespace Tyuiu.GolubevDS.Sprint1.Task0.V14.Test;
    using Tyuiu.GolubevDS.Sprint1.Task0.V14.Lib;

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
         DataService ds = new ();
        var res = ds.Calculate();
        Assert.AreEqual(25, res);
        }
    }
