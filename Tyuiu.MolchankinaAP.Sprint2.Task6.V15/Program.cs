using Tyuiu.MolchankinaAP.Sprint2.Task6.V15.Lib;
namespace Tyuiu.MolchankinaAP.Sprint2.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите день для проверки= ");
            int k = Convert.ToInt32(Console.ReadLine());
            string res = service1.FindDayName(k);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("День недели заданного вами дня: " + res);
            Console.ReadKey();
        }
    }
}
