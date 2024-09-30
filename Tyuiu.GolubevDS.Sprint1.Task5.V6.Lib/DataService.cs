namespace Tyuiu.GolubevDS.Sprint1.Task5.V6.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task5V6
{
    public int Calculate(int k)
    {
        int n;
        n = k - ((k - 1) / 7) * 7;
        return n;
    }
}
