using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoConstrutor
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Produto: {Nome} \nPreço: {Preco:C}");
        }
    }
}
