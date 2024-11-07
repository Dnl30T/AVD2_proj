using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool FazerAposta(decimal valorAposta)
        {
            int resultadoNumero = random.Next(0, 36);
            string resultadoCor = (resultadoNumero % 2 == 0) ? "Vermelho" : "Preto";

            if (tipoAposta == "Numero")
            {
 
                return numeroEscolhido == resultadoNumero;
            }
            else if (tipoAposta == "Cor")
            {

                return escolhaCor == resultadoCor;
            }


            return false;
        }

        public override void Apostar(decimal valor)
        {
            throw new NotImplementedException();
        }
    }

}
