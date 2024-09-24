namespace Tyuiu.GolubevDS.Sprint1.Task3.V4.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task3V4
{
    public double PurchaseAmount(double priceNotebook, double priceCover, int quantity) =>
    
        Math.Round(quantity * (priceNotebook + priceCover), 3);
    
}
