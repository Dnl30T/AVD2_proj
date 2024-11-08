using System.Collections.Generic;
using AVD2.src.Jogos;

namespace AVD2.src
{
    public class Cassino
    {
        private List<Jogo> jogos;
        private Jogador jogador;

        public Cassino(Jogador jogador)
        {
            this.jogador = jogador;
            jogos = new List<Jogo>();
        }

        public void AdicionarJogo(Jogo jogo)
        {
            jogos.Add(jogo);
        }

        public string ApostarNoCacaNiquel(decimal valorAposta)
        {
            var cacaNiquel = new CacaNiquel();
            return cacaNiquel.ExecutarAposta(valorAposta, jogador);
        }

        public string ApostarNaRoleta(decimal valorAposta, string tipoAposta, string escolhaCor = null, int numeroEscolhido = -1)
        {
            var roleta = new Roleta();
            roleta.DefinirAposta(tipoAposta, escolhaCor, numeroEscolhido);
            return roleta.ExecutarAposta(valorAposta, jogador);
        }
    }
}
