namespace PolimorfismoExFixação.Entidades
{
    public class ProdutoImportado : Produto
    {
        public double CustoAdicional { get; set; }

        public ProdutoImportado(string nome, double preco, double custoAdicional)
            : base(nome, preco)
        {
            CustoAdicional = custoAdicional;
        }

        public double RetornarPrecoTotal()
        {
            return Preco + CustoAdicional;
        }

        protected override double RetornarPreco()
        {
            return RetornarPrecoTotal();
        }

        public override string Etiqueta()
        {
            return base.Etiqueta() + $" (Custo adicional R${CustoAdicional:F2})";
        }
    }
}
