using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class ContaBancaria
    {
        public string Titular;
        public double Saldo;

        public double Depositar(double valor)
        {
            return Saldo += valor;
        }
        public double Sacar(double valor)
        {
            if (Saldo - valor < 0)
            {
                string mensagem = "Saldo insuficiente!";
                Console.WriteLine(mensagem);
                return Saldo;
            }
            else

            {
                return Saldo - valor;
            }
        }
        public void ExibirSaldo()
        {

            Console.WriteLine($"Saldo de {Titular}: R$ {Saldo}");

        }
        

    }
}
