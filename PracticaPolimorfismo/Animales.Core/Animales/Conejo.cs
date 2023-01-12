using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales.Core.Animales
{
    public class Conejo : Animal
    {
        public Conejo(string edad, string peso, string altura, int zanahoriasComidas) : base(edad, peso, altura)
        {
            ZanahoriasComidas = zanahoriasComidas;
        }

        public int ZanahoriasComidas { get; set; }

        public override string ImprimirComida()
        {
            return "Debe comer zanahorias";
        }

        public override string ImprimirPropiedades()
        {
            return "Conejo:\n" + base.ImprimirPropiedades() + $"{ZanahoriasComidas}";
        }
    }
}
