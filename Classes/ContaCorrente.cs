namespace Entrevista_Tecnica_GFT_START_4_2022_CSharp.Classes
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(string numero, string titular, double saldo) : base(numero, titular, saldo)
        {
            
        }

        public override double Redimento(double juros)
        {

            return (Saldo - 0.75) + Saldo * juros;
        }

        public void RetornaDados()
        {
            double valorP = Redimento(0.05);
            Console.WriteLine("O saldo da Conta corrente de {0} é de {1}", this.Titular, valorP.ToString("C"));
        }
    }
}