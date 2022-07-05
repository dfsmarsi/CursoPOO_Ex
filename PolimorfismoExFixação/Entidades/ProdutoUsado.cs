using System;

namespace PolimorfismoExFixação.Entidades
{
    public class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao)
            : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string Etiqueta()
        {
            return base.Etiqueta() + $" (Data Fabricação: {DataFabricacao:d}) (usado)";
        }
    }
}
