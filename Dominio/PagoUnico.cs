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

        public PagoUnico(MetodoPago metodo, TipoGasto tipoGasto, Usuario usuario, string descripcion, DateTime fechaPago, string nroRecibo, double monto ) 
            : base(metodo, tipoGasto, usuario, descripcion, monto)
        {
            this.fechaPago = fechaPago;
            this.nroRecibo = nroRecibo;

            if (nroRecibo == null || nroRecibo == "")
            {
                throw new Exception("El número de recibo no puede estar vacío.");
            }
        }

        public override double CalcularTotal()
        {
            double descuento = 0.10; // 10% de descuento

            if (Metodo == MetodoPago.EFECTIVO)
            {
                descuento = 0.20; // 20% de descuento
            }

            double total = Monto - (Monto * descuento);
            return total;
        }

       

     

        public override string ToString()
        {
            return $"Pago Unico - Id: {Id}, Usuario - {Usuario.Email}, Tipo Gasto - {TipoGasto.Nombre}, Metodo {Metodo}, Descripcion {Descripcion}, Fecha {fechaPago.ToString("dd/MM/yyyy")}, Total - {CalcularTotal().ToString("0.00")} ";
        }
    }
}