using Tyuiu.MolchankinaAP.Sprint2.Task5.V12.Lib;
namespace Tyuiu.MolchankinaAP.Sprint2.Task5.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int g, m, n;
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение год: ");
            g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение месяц: ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение день: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сегодня " + $"{g}.{m}.{n}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Вчерашняя дата " + ds.FindDateOfPreviousDay(g, m, n));
        }
    }
}
