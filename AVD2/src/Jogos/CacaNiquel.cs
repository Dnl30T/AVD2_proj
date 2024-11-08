using System;

namespace AVD2.src.Jogos
{
    public class CacaNiquel : Jogo
    {
        private static Random random = new Random();

        public CacaNiquel() : base("Caça-Níquel")
        {
        }

        public override void Apostar(decimal valor)
        {
            Console.WriteLine($"Apostando {valor} no caça-níquel...");
        }

        public string ExecutarAposta(decimal valorAposta, Jogador jogador)
        {
            if (!jogador.PodeApostar(valorAposta))
                return "Saldo insuficiente para realizar a aposta.";

            jogador.AtualizarSaldo(-valorAposta);

            bool venceu = random.Next(0, 2) == 1;
            if (venceu)
            {
                decimal premio = valorAposta * 2;
                jogador.AtualizarSaldo(premio);
                return $"Você ganhou {premio:C} no Caça-Níquel!";
            }
            else
            {
                return "Você perdeu no Caça-Níquel!";
            }
        }
    }
}
