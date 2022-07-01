namespace PolimorfismoEx1.Entidades
{
    public class FuncionarioTerceirizado : Funcionario
    {
        public double DespesaAdicional { get; set; }

        public FuncionarioTerceirizado(string nome, int horas, double valorHora, double despesaAdicional)
            : base(nome, horas, valorHora)
        {
            DespesaAdicional = despesaAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + (DespesaAdicional * 1.1);
        }
    }
}
