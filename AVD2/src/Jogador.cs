using System;

namespace AVD2.src
{
    public class Jogador
    {
        public string Nome { get; private set; }
        public decimal Saldo { get; private set; }

        public Jogador(string nome, decimal saldoInicial)
        {
            Nome = nome;
            Saldo = saldoInicial;
        }

        public bool PodeApostar(decimal valor)
        {
            return valor > 0 && valor <= Saldo;
        }

        public void AtualizarSaldo(decimal valor)
        {
            Saldo += valor;
        }
    }
}
