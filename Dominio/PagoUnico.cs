using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class PagoUnico : Pago
    {
        public DateTime fechaPago;
        public string nroRecibo;

        public PagoUnico(MetodoPago metodo, TipoGasto tipoGasto, Usuario usuario, string descripcion, DateTime fechaPago, string nroRecibo) 
            : base(metodo, tipoGasto, usuario, descripcion)
        {
            this.fechaPago = fechaPago;
            this.nroRecibo = nroRecibo;
        }
    }
}
