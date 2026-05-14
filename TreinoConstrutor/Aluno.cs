using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoConstrutor
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Curso { get; set; }
        public double NotaFinal { get; set; }

        public Aluno(string nome)
        {
            Nome = nome;
            Curso = "Indefinido"; //Valor padrão caso não seja fornecido
            NotaFinal = 0.0; //Valor padrão caso não seja fornecido
        }

        public Aluno(string nome, string curso)
        {
            Nome = nome;
            Curso = curso;
            NotaFinal = 0.0; //Valor padrão caso não seja fornecido
        }

        public Aluno(string nome, string curso, double notaFinal)
        {
            Nome = nome;
            Curso = curso;
            NotaFinal = notaFinal;
        }

        public void ExibirAlunos()
        {
            Console.WriteLine($"\nNome: {Nome} \nCurso: {Curso} \nNota Final: {NotaFinal}");
        }
    }
}
