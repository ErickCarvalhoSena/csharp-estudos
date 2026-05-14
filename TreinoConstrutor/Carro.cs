using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoConstrutor
{
    public class Carro
    {
        public string Modelo  { get; set; }
        public int Ano { get; set; }

        public Carro(string modelo)
        {
            Modelo = modelo;
            Ano = 2026; //Valor padrão caso não seja fornecido
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo} \nAno: {Ano}");
        }
    }
}
