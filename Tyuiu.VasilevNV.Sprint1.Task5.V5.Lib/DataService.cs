using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.VasilevNV.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            if (x < 0)
            {
                throw new ArgumentException("Число должно быть положительным.");
            }

            string numberString = x.ToString(System.Globalization.CultureInfo.InvariantCulture);

            int dotIndex = numberString.IndexOf('.');
            if (dotIndex != -1 && dotIndex + 1 < numberString.Length)
            {

                return int.Parse(numberString[dotIndex + 1].ToString());
            }
            return 0;
        }
    }
}