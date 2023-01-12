using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez.Core.Pieza
{
    public class Torre : Pieza
    {
        public override string Mover()
        {
            return "\nTorre:\nMoviendose al frente";
        }
    }
}
