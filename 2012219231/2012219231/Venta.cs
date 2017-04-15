using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231
{
    public class Venta
    {
        private Administrativo _administrativo;
        private Cliente _Cliente;
        private TipoComprobante _TipoComprobante;
        private TipoPago _TipoPago;
        private Servicio _servicio;

        public Administrativo Administrativo
        {
            get
            {
                return _administrativo;
            }
        
    }

        public Cliente Cliente
        {
            get
            {
                return _Cliente;
            }

        }
        public TipoComprobante TipoComprobante
        {
            get
            {
                return _TipoComprobante;
            }

        }
        public TipoPago TipoPago
        {
            get
            {
                return _TipoPago;
            }

        }
        public Servicio Servicio
        {
            get
            {
                return _servicio;
            }

        }
    }
}

