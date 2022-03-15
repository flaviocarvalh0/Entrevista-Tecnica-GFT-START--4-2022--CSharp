
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

        static void Questao2()
        {
            Console.WriteLine("Entre com um valor entre 350 e 8750");
            int entrada = Int32.Parse(Console.ReadLine());


            while (entrada.ToString().Length < 3 || entrada.ToString().Length > 4)
            {
                if (entrada < 350 || entrada > 8750)
                {
                    entrada = Int32.Parse(Console.ReadLine());
                }
                Console.WriteLine("A entrada de possuir no mínimo 3 caracteres e no máximo 4, tente novamente!");
                entrada = Int32.Parse(Console.ReadLine());

                int qtdImp = 0;

                for (int i = 0; i < entrada.ToString().Length; i++)
                {
                    if (Int32.Parse(entrada.ToString().Substring(i, 1)) % 2 != 0)
                    {
                        qtdImp = qtdImp + 1;
                    }
                }

                Console.WriteLine("Quantidade de impares é = " + qtdImp);
            }
        }
        static void Questao3()
        {
            Console.WriteLine("Conta Corrente");
            Console.Write("Informe o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Informe o numero da conta: ");
            string conta = Console.ReadLine();
            ContaCorrente contaC = new ContaCorrente(conta, nome, 5780.99);

            Console.WriteLine("Conta Poupança");
            Console.Write("Informe o nome: ");
            string nomeP = Console.ReadLine();
            Console.Write("Informe o numero da conta: ");
            string contaPop = Console.ReadLine();
            ContaPoupança contaP = new ContaPoupança(contaPop, nomeP, 1500000.00);


            contaC.RetornaDados();
            contaP.RetornaDadosP();


        }
        static void Questao4()
        {
            Pessoa pessoa = new Pessoa();

            Console.Write("Por favor informe seu nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Por favor sua Altura em metros ex: 1,69 : ");
            pessoa.Altura = double.Parse(Console.ReadLine());
            Console.Write("Por favor informe seu peso ex: 76,6 : ");
            pessoa.Peso = double.Parse(Console.ReadLine());

            double valor = pessoa.CalculaIMC();
            Console.Write(valor.ToString("F"));
        }
        public static void Main()
        {

            Questao2();
        }
    }
}