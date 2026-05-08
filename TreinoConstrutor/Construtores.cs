using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoConstrutor
{
    internal class Construtores
    {

        public class Pessoa
        {
            public string Nome { get; set; }
            
            public Pessoa(string nome)
            {
                Nome = nome;
            }
        }

        public void exibir()
        {
            Produto produto = new Produto();
            Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco}");
        }

         public class Produto
        { 
           public string Nome { get; set; }
           public double Preco { get; set; }

            public Produto()
            {
                Nome = "Sem nome";
                Preco = 0.0;
            }
        }
    }
}
