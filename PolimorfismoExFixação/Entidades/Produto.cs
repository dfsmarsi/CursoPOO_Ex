namespace PolimorfismoExFixação.Entidades
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        protected virtual double RetornarPreco()
        {
            return Preco;
        }

        public virtual string Etiqueta()
        {
            return $"{Nome} R${RetornarPreco():F2}";
        }
    }
}
