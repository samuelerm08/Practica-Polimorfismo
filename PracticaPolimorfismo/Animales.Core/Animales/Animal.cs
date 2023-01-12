using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales.Core.Animales
{
    public abstract class Animal
    {
        public Animal(string edad, string peso, string altura)
        {
            Edad = edad;
            Peso = peso;
            Altura = altura;
        }

        public string Edad { get; }
        public string Peso { get; }
        public string Altura { get; }
        public abstract string ImprimirComida();
        public virtual string ImprimirPropiedades()
        {
            return $"{Edad}\n" +
                   $"{Peso}\n" +
                   $"{Altura}\n";
        }
    }
}
