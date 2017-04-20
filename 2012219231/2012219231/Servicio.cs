using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231
{
    public abstract class Servicio
    {

       public abstract void tipoServicio(int tipo);
        private int tipServicio;

        public int Tipo
        {
            get { return tipServicio; }
            set { tipServicio = value; }
        }

        public Servicio(int tipo)
        {
            Tipo = tipo;
        }
          
    }

    

}
