namespace PolimorfismoEx1.Entidades
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorHora  { get; set; }

        public Funcionario(string nome, int horas, double valorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorHora = valorHora;
        }

        public virtual double Pagamento()
        {
            return Horas * ValorHora;
        }
    }
}
