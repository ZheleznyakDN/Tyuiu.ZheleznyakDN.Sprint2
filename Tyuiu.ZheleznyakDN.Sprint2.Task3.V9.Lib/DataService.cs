using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZheleznyakDN.Sprint2.Task3.V9.Lib
{
    public class DataService : ISprint2Task3V9
    {
        public double Calculate(double x)
        {
            double result;

            if (x > 0)
            {
                double baseValue = (x + 15) / (x - 7);
                result = x * Math.Pow(baseValue, x);
            }
            else if (x == 0)
            {
                result = Math.Sin(x) + Math.Cos(x);
            }
            else
            {
                if (x > -13)
                {
                    result = 1 + (4 / (x * x));
                }
                else
                {
                    result = x + 10 * x + (1 / x);
                }
            }

            return Math.Round(result, 3);
        }
    }
}
