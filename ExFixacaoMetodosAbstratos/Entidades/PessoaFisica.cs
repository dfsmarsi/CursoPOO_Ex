namespace ExFixacaoMetodosAbstratos.Entidades
{
    class PessoaFisica : Pessoa
    {
        public double ValorGastoSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double valorGastoSaude) 
            : base(nome, rendaAnual)
        {
            ValorGastoSaude = valorGastoSaude;
        }

        public override double CalcularImposto()
        {
            double valorImposto = 0.0;
            if (RendaAnual < 20000.00)
                valorImposto = RendaAnual * 0.15;
            else
                valorImposto = RendaAnual * 0.25;
            if (ValorGastoSaude > 0.0)
                valorImposto = valorImposto - ValorGastoSaude * 0.5;
            
            return valorImposto;
        }
    }
}
