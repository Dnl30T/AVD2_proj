using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVD2.src.Jogos
{
    public class CacaNiquel : Jogo
    {
        public CacaNiquel() : base("Caça-Níquel")
        {
        }

        public override void Apostar(decimal valor)
        {
            // Implementação de aposta
            Console.WriteLine($"Apostando {valor} no caça-níquel...");
        }
    }

}
