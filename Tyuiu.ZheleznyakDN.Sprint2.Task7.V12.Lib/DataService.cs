using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZheleznyakDN.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool area1 = (x <= 0) && (y >= 2 - x) && (y >= x * x);
            bool area2 = (x >= 0) && (y <= 2 - x) && (y >= x * x);

            return area1 || area2;
        }
    }
}
