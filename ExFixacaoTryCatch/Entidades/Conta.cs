using ExFixacaoTryCatch.Entidades.Excecoes;

namespace ExFixacaoTryCatch.Entidades
{
    class Conta
    {
        public int NumeroConta { get; set; }
        public string NomeTitular { get; set; }
        public double SaldoConta { get; set; }
        public double LimiteSaque { get; set; }

        public Conta(int numero, string nome, double saldo, double limiteSaque)
        {
            NumeroConta = numero;
            NomeTitular = nome;
            SaldoConta = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double valor)
        {
            SaldoConta += valor;
        }

        public void Saque (double valor)
        {
            if (SaldoConta <= 0.0)
                throw new DomainException("Saldo zerado ou negativo, não é possível realizar saque!");
            if (valor > SaldoConta)
                throw new DomainException($"Não há saldo suficiente para o saque! Saldo atual {SaldoConta}");
            if (valor > LimiteSaque)
                throw new DomainException($"Valor de saque maior que o limite! Seu limite é: {LimiteSaque}");
            
            SaldoConta -= valor;
        }

        public override string ToString()
        {
            return $"Dados da conta:\n Titular: {NomeTitular} \n Saldo: {SaldoConta}";
        }
    }
}
