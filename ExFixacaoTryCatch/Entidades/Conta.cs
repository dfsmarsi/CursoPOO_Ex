﻿using ExFixacaoTryCatch.Entidades.Excecoes

namespace ExFixacaoTryCatch.Entidades
{
    class Conta
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta(int numero, string nome, double saldo, double limiteSaque)
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque (double valor)
        {
            if (valor > Saldo)
                throw new DomainException($"Não há saldo suficiente para o saque! Saldo atual {Saldo}");
            if (Saldo <= 0.0)
                throw new DomainException("Saldo zerado ou negativo, não é possível realizar saque!");
            
            Saldo -= valor;
        }
    }
}
