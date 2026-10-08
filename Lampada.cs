using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Lampada
    {
        public bool Ligada;
        
        public bool Ligar()
        {
            return true;
        }

        public bool Desligar()
        {
            return false;
        }
        public bool Alternar()
        {
            return !Ligada;
        }
        public void ExibirEstado()
        {
            if (Ligada == true) { Console.WriteLine("A lâmpada está ligada."); }



            else { Console.WriteLine("A lâmpada está desligada."); };
        }

    }
}
