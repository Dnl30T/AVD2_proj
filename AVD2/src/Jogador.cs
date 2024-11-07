using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void AtualizarSaldo(decimal valor)
        {
            Saldo += valor;
        }
    }

}
