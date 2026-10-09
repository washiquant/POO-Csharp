using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Calculadora
    {
        public int somar(int a, int b)
        {
            return a + b;
        }

        public int subtrair(int a, int b)
        {
            return a - b;
        }

        public void MostrarResultado(int valor)
        {
            Console.WriteLine($"Resultado: {valor}");
        }

    }
}
