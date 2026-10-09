using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp1
{
    public class Cofrinho
    {
        //Atributos
        
        public string Dono;
        public double Saldo;


        //Construtor
        public Cofrinho(string Dono)
        {
            this.Dono = Dono;
  
        }

        //Metodo Guardar

        public void Guardar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor invalido");
            }
            else
            {
                Console.WriteLine($"Guardou R$ {valor}");
            }
        }

        // Metodo Retirar

        public bool Retirar(double valor)
        {
            if (Saldo > 0)
            {
                Saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Metodo FaltaParaMeta

        public double FaltaParaMeta(double meta)
        {
            return meta - Saldo;
        }
              

    }
}

