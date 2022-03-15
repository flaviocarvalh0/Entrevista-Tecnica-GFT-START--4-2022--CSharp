namespace Entrevista_Tecnica_GFT_START_4_2022_CSharp.Classes
{
    public abstract class Colaborador
    {
        public string Nome { get; set; }
        public int Idade { get; set; }  
        public double Salario { get; set; }
        public int GrauDeInstrucao { get; set; }

        public virtual double Bonificacao()
        {
            return  Salario * GrauDeInstrucao;
        }
    }
}