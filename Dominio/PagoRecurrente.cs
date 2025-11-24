namespace Dominio
{
    public class PagoRecurrente : Pago
    {
        public DateTime fechaDesde;
        public DateTime fechaHasta;
        public bool tieneLimite;

        public PagoRecurrente(
            MetodoPago metodo,
            TipoGasto tipoGasto,
            Usuario usuario,
            string descripcion,
            DateTime fechaDesde,
            DateTime fechaHasta,
            bool tieneLimite,
            double monto
        ) : base(metodo, tipoGasto, usuario, descripcion, monto)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.tieneLimite = tieneLimite;
        }

        public override void Validar()
        {
            // Validaciones Compartidas
            base.Validar();

            if (fechaDesde == DateTime.MinValue)
                throw new Exception("Debe indicar la fecha de inicio.");

            if (tieneLimite && fechaHasta < fechaDesde)
                throw new Exception("La fecha de fin no puede ser anterior a la fecha de inicio.");
        }

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
                recargo = 0.03; // sin límite: recargo fijo del 3%
            }
            else
            {
                if (meses >= 10)
                    recargo = 0.10;
                else if (meses >= 6)
                    recargo = 0.05;
                else
                    recargo = 0.03;
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
                recargo = 0.03;
                total = Monto + (Monto * recargo);
            }

            return total;
        }

        public bool EstaActivoEnMes()
        {
            // Si el pago no tiene límite, activo si ya empezó
            if (!tieneLimite)
            {
                return DateTime.Now.Month >= fechaDesde.Month && DateTime.Now.Year >= fechaDesde.Year;
            }
            else
            {
                return DateTime.Now >= fechaDesde && DateTime.Now <= fechaHasta;
            }
        }

        public override bool EsDelMes(int mes, int anio)
        {
            return fechaDesde.Month == mes && fechaDesde.Year == anio;
        }

        public override double MontoParaOrdenar()
        {
            return Monto; // cuota mensual
        }

        public override string ToString()
        {
            return $"Pago Recurrente - Id: {Id}, Usuario - {Usuario.Email}, Tipo Gasto - {TipoGasto.Nombre}, Metodo {Metodo}, Descripcion {Descripcion}, Desde {fechaDesde:dd/MM/yyyy}, Total - {CalcularTotal():0.00}";
        }
    }
}


