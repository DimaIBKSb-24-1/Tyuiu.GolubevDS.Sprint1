namespace Tyuiu.GolubevDS.Sprint1.Task4.V25.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task4V25
{
    public double Calculate(double a)
    {
        return Math.Round(1-Math.Cos(a)/Math.Pow(Math.Sin(a), 2), 3);
        
    }
}
