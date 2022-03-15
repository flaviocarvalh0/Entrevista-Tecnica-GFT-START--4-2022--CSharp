namespace Entrevista_Tecnica_GFT_START_4_2022_CSharp.Classes
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }

        public double CalculaIMC()
        {
            
            double imc = Peso / (Altura * Altura);

            if(imc < 18.5)
            {
                Console.WriteLine("Abaixo do Peso");
            }else if(imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Peso Normal");
            }else if(imc >= 25.0 && imc <= 29.9 )
            {
                Console.WriteLine("Sobrepeso");
            }else if(imc >= 30.0 && imc <= 34.9)
            {
                Console.WriteLine("Obesidade Grau I");
            }else if(imc >= 35.0 && imc <= 39.9)
            {
                Console.WriteLine("Obesidade Grau II");
            }else
            {
                Console.WriteLine("Obesidade Grau III");
            }

            return imc;
            
        }
    }
}