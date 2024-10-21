using Tyuiu.MolchankinaAP.Sprint2.Task1.V22.Lib;
namespace Tyuiu.MolchankinaAP.Sprint2.Task1.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 324;
            int b = 696;
            int c = 254;
            int d = 155;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Молчанкина А.П. | СМАРТб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* спринт #2                                                               *");
            Console.WriteLine("* Тема : Операции сравнения                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Молчанкина Ангелина Павловна | СМАРТб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений                                *");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую последовательность*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*  массив: (True, True, True, False, False, False),                       *");
            Console.WriteLine("*   при a = 324, b = 696, c = 254, d = 155                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("A=" + a);
            Console.WriteLine("B=" + b);
            Console.WriteLine("C=" + c);
            Console.WriteLine("D=" + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат:");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
