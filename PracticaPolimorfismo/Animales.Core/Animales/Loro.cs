using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales.Core.Animales
{
    public class Loro : Animal
    {
        public Loro(string edad, string peso, string altura, int semillasComidas) : base(edad, peso, altura)
        {
            SemillasComidas = semillasComidas;
        }

        public int SemillasComidas { get; set; }

        public override string ImprimirComida()
        {
            return "Debe comer semillas";
        }

        public override string ImprimirPropiedades()
        {
            return "Loro:\n" +  base.ImprimirPropiedades() + $"{SemillasComidas}";
        }
    }
}
