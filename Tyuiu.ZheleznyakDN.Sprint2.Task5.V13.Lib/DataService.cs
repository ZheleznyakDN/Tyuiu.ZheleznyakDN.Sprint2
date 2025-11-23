using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZheleznyakDN.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int nextDay = n + 1;
            int nextMonth = m;
            int nextYear = g;

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (nextDay > 31)
                    {
                        nextDay = 1;
                        nextMonth++;
                    }
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    if (nextDay > 30)
                    {
                        nextDay = 1;
                        nextMonth++;
                    }
                    break;

                case 2:

                    if (nextDay > 29)
                    {
                        nextDay = 1;
                        nextMonth++;
                    }
                    break;
            }


            if (nextMonth > 12)
            {
                nextMonth = 1;
                nextYear++;
            }

            return $"{nextDay:D2}.{nextMonth:D2}.{nextYear}";
        }
    }
}
