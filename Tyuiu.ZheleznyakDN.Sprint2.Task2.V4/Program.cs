using Tyuiu.ZheleznyakDN.Sprint2.Task2.V4.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint2.Task2.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Железняк Д.Н. | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Железняк Дамир Николаевич | ПКТб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая проверяет, попадает ли точка с координатами *");
            Console.WriteLine("* X и Y в затененную область.                                             *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите координату X: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату Y: ");
            int y = int.Parse(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Точка с координатами (X = " + x + ", Y = " + y + ")");
            Console.WriteLine("Находится в затененной области: " + res);
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
