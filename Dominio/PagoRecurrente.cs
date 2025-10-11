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


        public PagoRecurrente(MetodoPago metodo, TipoGasto tipoGasto, Usuario usuario, string descripcion, DateTime fechaDesde, DateTime fechaHasta, bool tieneLimite, double monto)
            : base(metodo, tipoGasto, usuario, descripcion, monto)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.tieneLimite = tieneLimite;
        }
        // Metodos auxiliares privados que los usaremso en los metodos publicos
        private int CalcularMeses(DateTime fechaDesde, DateTime fechaHasta)
        {
            int meses = (fechaHasta.Year - fechaDesde.Year) * 12 + fechaHasta.Month - fechaDesde.Month + 1;
            return meses;
        }

        private double CalcularRecargo(int meses, bool tieneLimite)
        {
            double recargo = 0;
            if (!tieneLimite)
            {
                recargo = 0.03; // Si no tiene limite es el recargo fijo del 3%
            }

            else
            {
                if (meses >= 10)
                {
                    recargo = 0.10; // si los meses son 10 o mas el recargo es del 10%
                }
                if (meses >= 6 && meses <= 9)
                {
                    recargo = 0.05; // si los meses son entre 6 y 9 el recargo es del 5%
                }
                if (meses < 6)
                {
                    recargo = 0.03; // si los meses son menos de 6 el recargo es del 3%
                }
            }
            return recargo;


        }

        public override double CalcularTotal()
        {
            double total;
            double recargo;

            if (tieneLimite)
            {
                int meses = CalcularMeses(fechaDesde, fechaHasta);
                recargo = CalcularRecargo(meses, tieneLimite);
                total = Monto + (Monto * recargo);
            }
            else
            {
                // Caso sin límite recargo fijo del 3%
                recargo = 0.03;
                total = Monto + (Monto * recargo);
            }

            return total;
        }

        public override bool EstaActivoEnMes(DateTime fechaReferencia)
        {
            // Si el pago no tiene límite (sin fechaHasta), siempre está activo
            if (!tieneLimite)
            {
                if (fechaReferencia >= fechaDesde)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                // Con límite activo si la fecha de referencia está entre fechaDesde y fechaHasta
                if (fechaReferencia >= fechaDesde && fechaReferencia <= fechaHasta)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override string ToString()
        {
            return $"Pago Recurrente - Id: {Id}, Usuario - {Usuario.Email}, Tipo Gasto - {TipoGasto.Nombre}, Metodo {Metodo}, Descripcion {Descripcion}, Desde {fechaDesde.ToString("dd/MM/yyyy")}, Total - {CalcularTotal().ToString("0.00")}";
        }


    }

}

