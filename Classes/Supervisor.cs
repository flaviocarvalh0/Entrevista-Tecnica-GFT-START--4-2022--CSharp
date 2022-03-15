namespace Entrevista_Tecnica_GFT_START_4_2022_CSharp.Classes
{
    public class Supervisor : Colaborador
    {
         public override double Bonificacao()
        {
            return Salario + 500.00 * GrauDeInstrucao * 3;
        }
    }
}