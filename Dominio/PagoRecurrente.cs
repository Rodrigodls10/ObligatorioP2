using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class PagoRecurrente : Pago
    {
        public DateTime fechaDesde;
        public DateTime fechaHasta;
        public bool tieneLimite;
        public decimal montoMensual;

        public PagoRecurrente(MetodoPago metodo, TipoGasto tipoGasto, Usuario usuario, string descripcion, DateTime fechaDesde, DateTime fechaHasta, bool tieneLimite, decimal montoMensual, double monto) 
            : base(metodo, tipoGasto, usuario, descripcion, monto)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.tieneLimite = tieneLimite;
            this.montoMensual = montoMensual;
        }
    }
}
