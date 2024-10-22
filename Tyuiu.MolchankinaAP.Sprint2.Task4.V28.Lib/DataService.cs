﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MolchankinaAP.Sprint2.Task4.V28.Lib
{
    public class DataService : ISprint2Task4V28
    {
        public double Calculate(double x, double y)
        {
            double z = (x < y * 2 - 10) ? Math.Round(Math.Pow(1 + (((y + 2) / (Math.Pow(x, 2)))), x)) : Math.Round(((2 * Math.Pow(x, 2) - Math.Cos(Math.Pow(y, 2)) + 12) / (Math.Pow(y, 2) - Math.Sin(Math.Pow(x, 2)) + 9)), 3);
            return z;
        }
    }
}
