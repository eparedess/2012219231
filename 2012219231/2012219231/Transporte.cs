using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231
{
   public class Transporte : Servicio
    {
        private LugarViaje _lugar;
        private TipoViaje _tipo;
        private Cliente _cliente;
        

        public LugarViaje LugarViaje {
            get
            {
                return _lugar;
            }
        }
        public TipoViaje TipoViaje
        {
            get
            {
                return _tipo;
            }
        }
        public Cliente Cliente { get { return _cliente; } }
       
        public Transporte()
        {

        }
    }
}
