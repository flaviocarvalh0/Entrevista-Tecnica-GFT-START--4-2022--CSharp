namespace Entrevista_Tecnica_GFT_START_4_2022_CSharp.Classes
{
    public abstract class Conta
    {
        protected Conta(string numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        protected string Numero { get; set; }
        protected string Titular { get; set; }
        protected double Saldo { get; set; }

        public virtual double Redimento(double juros)
        {
            return  Saldo * juros;
        }
    }
}