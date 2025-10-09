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

        public PagoUnico(MetodoPago metodo, TipoGasto tipoGasto, Usuario usuario, string descripcion, DateTime fechaPago, string nroRecibo, decimal monto ) 
            : base(metodo, tipoGasto, usuario, descripcion, monto)
        {
            this.fechaPago = fechaPago;
            this.nroRecibo = nroRecibo;

            if (nroRecibo == null || nroRecibo == "")
            {
                throw new Exception("El número de recibo no puede estar vacío.");
            }
        }

        public override decimal CalcularTotal()
        {
            decimal descuento = 0.10m; // 10% de descuento

            if (Metodo == MetodoPago.EFECTIVO)
            {
                descuento = 0.20m; // 20% de descuento
            }

            decimal total = Monto - (Monto * descuento);
            return total;
        }

        public override bool EstaActivoEnMes(DateTime referencia)
        {
            if (fechaPago.Year == referencia.Year && fechaPago.Month == referencia.Month)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public override decimal ImporteDelMes(DateTime referencia)
        {
            if (EstaActivoEnMes(referencia))
            {
                return CalcularTotal();
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"Pago Unico - Id: {Id}, Usuario - {Usuario.Email}, Tipo Gasto - {TipoGasto.Nombre}, Metodo {Metodo}, Descripcion {Descripcion}, Fecha {fechaPago.ToString("dd/MM/yyyy")}, Total - {CalcularTotal().ToString("0.00")} ";
        }
    }
}