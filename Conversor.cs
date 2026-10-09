using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Conversor
    {
        public double CelsiusParaFahrenheit(double celsius)
        {
            return celsius * 1.8 + 32;
        }
        public bool EstaQuente(double celsius)
        {
            if (celsius >= 30)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
