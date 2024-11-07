using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVD2.src
{
    public abstract class Jogo : IAposta
    {
        public string Nome { get; protected set; }

        protected Jogo(string nome)
        {
            Nome = nome;
        }

        public abstract void Apostar(decimal valor); // Método abstrato que será implementado pelas subclasses
    }

}
