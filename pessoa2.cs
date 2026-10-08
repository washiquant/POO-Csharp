using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class pessoa2
    {
        public string Nome;

        //Metodos
        public void Cumprimentar()
        {
            Console.WriteLine($"Olá, eu sou {Nome}");
        }
        //
        public void CumprimentarAlguem(string outraPessoa)
        {
            Console.WriteLine($" Olá, {outraPessoa}! Eu sou {Nome}.");
        }
        //
        public string ObterApresentacao()
        {
            return ($" Meu nome é {Nome}. (não mostra na tela)");
        }

    }
}   
