using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231
{
    public class Tripulacion : Empleado
    {
        private TipoTripulacion _tipo;
        public TipoTripulacion TipoTripulacion
        {
            get
            {
                return _tipo;
            }
        }

        
    }
}
