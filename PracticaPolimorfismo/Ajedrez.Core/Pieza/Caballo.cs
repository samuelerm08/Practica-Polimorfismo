using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez.Core.Pieza
{
    public class Caballo : Pieza
    {        
        public override string Mover()
        {
            return "\nCaballo:\nMoviendose a la derecha";
        }
    }
}
