namespace Tyuiu.GolubevDS.Sprint1.Task6.V5.Test;
using Tyuiu.GolubevDS.Sprint1.Task6.V5.Lib;
[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidString()
    {
        DataService ds = new DataService();
        string text = "����� ��� ����� ������";
        string res = ds.CheckSymmetricalWords(text);
        Assert.AreEqual("�����, �����", res);
    }
}
