using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVD2.src
{
    public class Cassino
    {
        private List<Jogo> jogos; // Associação com múltiplos jogos
        public Jogador Jogador { get; private set; } // Relacionamento com jogador

        public Cassino(Jogador jogador)
        {
            Jogador = jogador;
            jogos = new List<Jogo>();
        }

        public void AdicionarJogo(Jogo jogo)
        {
            jogos.Add(jogo);
        }

        public void ListarJogos()
        {
            foreach (var jogo in jogos)
            {
                Console.WriteLine(jogo.Nome);
            }
        }
    }

}
