namespace Entrevista_Tecnica_GFT_START_4_2022_CSharp.Classes
{
    public class ContaPoupança : Conta
    {
        public ContaPoupança(string numero, string titular, double saldo) : base(numero, titular, saldo)
        {
            
        }

        public override double Redimento(double juros)
        {

            return Saldo + Saldo * juros;
        }

        public void RetornaDadosP()
        {
            double valorP = Redimento(0.07);
            Console.WriteLine("O saldo da Conta corrente de {0} é de {1}", this.Titular, valorP.ToString("C"));
        }
    }
}