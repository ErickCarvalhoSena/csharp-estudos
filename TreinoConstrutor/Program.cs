namespace TreinoConstrutor
{

    
    internal class Program
    {
        static void Main(string[] args)
        {

            //aprendendo construtores com parametros
            Pessoa pessoa1 = new Pessoa("Erick", 22);
            pessoa1.Exibir();

            Pessoa pessoa2 = new Pessoa("Auricelia", 22);
            pessoa2.Exibir();

            Console.WriteLine("--------------------------------------------------");

            // aprendendo construtores Pt2
            Produto produto1 = new Produto("Notebook", 3500.00);
            produto1.MostrarDados();

            Console.WriteLine("--------------------------------------------------");

            //Construtor com valor padrão
            Carro carro1 = new Carro("Fusca");
            carro1.MostrarInformacoes();

            Console.WriteLine("--------------------------------------------------");

            //Sobrecarga de construtores Pt1

            //Construtor sem parâmetros
            ContaBancaria conta1 = new ContaBancaria();
            conta1.ExibirContas();

            //construtor com apenas 1 parâmetro
            ContaBancaria conta2 = new ContaBancaria("Erick");
            conta2.ExibirContas();
            
            //construtor com 2 parâmetros
            ContaBancaria conta3 = new ContaBancaria("Auricelia", 5000.00);
            conta3.ExibirContas();

            Console.WriteLine("--------------------------------------------------");

            //Sobrecarga de construtores Pt2

            //Construtor com valores padrão
            Aluno aluno1 = new Aluno("Erick");
            aluno1.ExibirAlunos();

            //Construtor com valores padrão Pt2
            Aluno aluno2 = new Aluno("Auricelia", "Melhoramento Genetico");
            aluno2.ExibirAlunos();

            //Sobrecarga de construtores Pt3
            Aluno aluno3 = new Aluno("Maria", "Medicina", 9.5);
            aluno3.ExibirAlunos();
        }
    }
}
