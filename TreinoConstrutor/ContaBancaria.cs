using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoConstrutor
{
    public class ContaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }
        
        public ContaBancaria()
        {
            Titular = "Desconecido";
            Saldo = 0.0;
        }

        public ContaBancaria(string titular)
        {
            Titular = titular;
            Saldo = 0.0;
        }

        public ContaBancaria(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        public void ExibirContas()
        {
            Console.WriteLine($"\nTitular: {Titular} \nSaldo: {Saldo:C}");
        }
    }
}
