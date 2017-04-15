using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231
{
   public class LugarViaje
    {
        //  private List<TipoLugar> _TipoLugar;
        // public LugarViaje(String Lugar)
        //{
        //  _TipoLugar = new List<TipoLugar>(Lugar);
        // }

        private TipoLugar _Lugar;
        public TipoLugar tipoLugar
        {
            get
            {
                return _Lugar;
            }
        }
        }
}
