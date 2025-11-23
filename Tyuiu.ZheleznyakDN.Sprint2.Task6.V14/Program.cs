using Tyuiu.ZheleznyakDN.Sprint2.Task6.V14.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint2.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Железняк Д.Н. | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Железняк Дамир Николаевич | ПКТб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели       *");
            Console.WriteLine("* является k-й день не високосного года, в котором 1 января d-й день      *");
            Console.WriteLine("* недели (1-понедельник, 2-вторник, ..., 7-воскресенье).                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер дня года (k): ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите день недели 1 января (d): ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            string result = ds.FindDayName(k, d);
            Console.WriteLine($"{k}-й день года является: {result}");

            Console.ReadKey();
        }
    }
}
