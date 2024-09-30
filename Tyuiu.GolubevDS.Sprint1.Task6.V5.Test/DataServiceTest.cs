namespace Tyuiu.GolubevDS.Sprint1.Task6.V5.Test;
using Tyuiu.GolubevDS.Sprint1.Task6.V5.Lib;
[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidString()
    {
        string strTest = "���� ����� ���� ����� ���� �����";
        DataService ds = new DataService();
        string[] slova = strTest.Split(' ');
        string res = "";
        for (int i = 0; i < slova.Length; i++)
        {
            string word = slova[i];
            string rev = new string(word.Reverse().ToArray());
            if (word == rev)
            {
                res += (word + " ");
            }
        }
        string wait = "����� ����� ";
        Assert.AreEqual(wait, res);
    }
}
