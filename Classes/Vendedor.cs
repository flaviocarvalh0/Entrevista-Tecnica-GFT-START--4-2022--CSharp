namespace Entrevista_Tecnica_GFT_START_4_2022_CSharp.Classes
{
    public class Vendedor : Colaborador
    {
        public override double Bonificacao()
        {
            return Salario + 300.00 * GrauDeInstrucao * 4;
        }
    }
}