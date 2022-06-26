
namespace ExComposicao3.Entidades
{
    public class PedidoItem
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public PedidoItem(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double CalcularSubTotal() => Quantidade * Preco;        
    }
}
