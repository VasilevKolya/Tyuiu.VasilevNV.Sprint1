using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.VasilevNV.Sprint1.Task4.V3.Lib
{
    public class DataService : ISprint1Task4V3
    {
        public double Calculate(double x, double y)
        {
            if (x == y)
            {
                throw new DivideByZeroException("Знаменатель не может быть равен нулю (x не должно быть равно y).");
            }

            double numerator = Math.Sqrt(3 * x); 
            double denominator = Math.Pow(x - y, 2); 
            double res = numerator / denominator;

            return res;
        }
    }
}