using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZheleznyakDN.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {
            int dayOfWeek = (d + k - 2) % 7 + 1;
            return dayOfWeek switch
            {
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                7 => "Воскресенье",
                _ => "Ошибка"
            };
    }   }
}
