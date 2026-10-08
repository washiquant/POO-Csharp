using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalcularArea(double Largura, double Altura)
        {
            return (Largura * Altura);
        }
        public double CalcularPerimetro(double Largura, double Altura)
        {
            return (2*(Largura * Altura));
        }

    }
}
