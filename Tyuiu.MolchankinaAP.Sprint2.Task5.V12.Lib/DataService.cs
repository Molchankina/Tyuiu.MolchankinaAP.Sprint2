using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MolchankinaAP.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int a = n;
            switch (n)
            {
                case 1:
                    n = 31;
                    break;

                default:
                    n -= 1; break;
            }

            switch (m)
            {
                case 2:
                    n -= 2;
                    break;

                case 1:
                    if (a == 1) { m = 12; g -= 1; }
                    break;

            }

            if (m < 10 && n < 10) { return $"0{n}.0{m}.{g}"; }
            if (m < 10) { return $"{n}.0{m}.{g}"; }
            if (n < 10) { return $"0{n}.{m}.{g}"; }
            else { return $"{n}.{m}.{g}"; }
        }
    }
}
