
using Entrevista_Tecnica_GFT_START_4_2022_CSharp.Classes;
using static System.Console;

namespace Principal
{
    class Program
    {

        static void Questao1()
        {
            Gerente gerente = new Gerente();
            gerente.Nome = "Flavio";
            gerente.Idade = 22;
            gerente.Salario = 1000.00;
            gerente.GrauDeInstrucao = 3;

            Supervisor supervisor = new Supervisor();
            supervisor.Nome = "Clécio";
            supervisor.Idade = 25;
            supervisor.Salario = 15000.00;
            supervisor.GrauDeInstrucao = 5;

            Vendedor vendedor = new Vendedor();

            vendedor.Nome = "João";
            vendedor.Idade = 28;
            vendedor.Salario = 1580.00;
            vendedor.GrauDeInstrucao = 2;

            Console.WriteLine("Salario + bonificações: {0}", gerente.Bonificacao());
            Console.WriteLine("Salario + bonificações: {0}", supervisor.Bonificacao());
            Console.WriteLine("Salario + bonificações: {0}", vendedor.Bonificacao());

            
        }
        public static void Main()
        {
            
            Questao1();
        }
    }
}