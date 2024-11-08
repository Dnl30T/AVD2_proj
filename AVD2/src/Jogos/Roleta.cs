using System;

namespace AVD2.src.Jogos
{
    public class Roleta : Jogo
    {
        private string tipoAposta;
        private string escolhaCor;
        private int numeroEscolhido;
        private static Random random = new Random();

        public Roleta() : base("Roleta")
        {
        }

        public void DefinirAposta(string tipoAposta, string escolhaCor, int numeroEscolhido)
        {
            this.tipoAposta = tipoAposta;
            this.escolhaCor = escolhaCor;
            this.numeroEscolhido = numeroEscolhido;
        }

        public override void Apostar(decimal valor)
        {
            Console.WriteLine($"Apostando {valor} na Roleta...");
        }

        public string ExecutarAposta(decimal valorAposta, Jogador jogador)
        {
            if (!jogador.PodeApostar(valorAposta))
                return "Saldo insuficiente para realizar a aposta.";

            jogador.AtualizarSaldo(-valorAposta);

            int resultadoNumero = random.Next(0, 36);
            string resultadoCor = (resultadoNumero % 2 == 0) ? "Vermelho" : "Preto";

            bool ganhou = (tipoAposta == "Numero" && numeroEscolhido == resultadoNumero) ||
                          (tipoAposta == "Cor" && escolhaCor == resultadoCor);

            if (ganhou)
            {
                decimal premio = valorAposta * 1.5m;
                jogador.AtualizarSaldo(premio);
                return $"Ganhou {premio:C}";
            }
            else
            {
                return "Perdeu";
            }
        }
    }
}
