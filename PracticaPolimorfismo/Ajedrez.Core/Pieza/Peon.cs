using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez.Core.Pieza
{
    public class Peon : Pieza
    {
        public override string Mover()
        {
            return "\nPeon:\nMoviendose a la izquierda";
        }
    }
}
