namespace Entrevista_Tecnica_GFT_START_4_2022_CSharp.Classes
{
    public class Gerente : Colaborador
    {
        public override double Bonificacao()
        {
            return Salario + 1000.00 * GrauDeInstrucao * 2;
        }
    }
}