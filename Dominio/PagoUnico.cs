namespace Dominio
{
    public class PagoUnico : Pago
    {
        public DateTime fechaPago;
        public string nroRecibo;

        public PagoUnico(
            MetodoPago metodo,
            TipoGasto tipoGasto,
            Usuario usuario,
            string descripcion,
            DateTime fechaPago,
            string nroRecibo,
            double monto
        ) : base(metodo, tipoGasto, usuario, descripcion, monto)
        {
            this.fechaPago = fechaPago;
            this.nroRecibo = nroRecibo;
        }

        public override void Validar()
        {
            // Validaciones Compartidas, luego vendrian las de la calse especifica
            base.Validar();

            if (fechaPago == DateTime.MinValue)
                throw new Exception("Debe indicar la fecha de pago.");

            if (string.IsNullOrWhiteSpace(nroRecibo))
                throw new Exception("El número de recibo no puede estar vacío.");
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

        public override bool EsDelMes(int mes, int anio)
        {
            return fechaPago.Month == mes && fechaPago.Year == anio;
        }

        public override string ToString()
        {
            return $"Pago Unico - Id: {Id}, Usuario - {Usuario.Email}, Tipo Gasto - {TipoGasto.Nombre}, Metodo {Metodo}, Descripcion {Descripcion}, Fecha {fechaPago:dd/MM/yyyy}, Total - {CalcularTotal():0.00} ";
        }
    }
}