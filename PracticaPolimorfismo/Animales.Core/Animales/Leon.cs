using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales.Core.Animales
{
    public class Leon : Animal
    {
        public Leon(string edad, string peso, string altura, int cantCaceria) : base(edad, peso, altura)
        {
            CantCaceria = cantCaceria;
        }

        public int CantCaceria { get; set; }

        public override string ImprimirComida()
        {
            return "Debe comer carne";
        }

        public override string ImprimirPropiedades()
        {
            return "Leon:\n" + base.ImprimirPropiedades() + $"{CantCaceria}";
        }                   
    }
}
