namespace Dominio
{
    public abstract class Pago : IValidable , IComparable<Pago>
    {
        public static int siguienteId = 1;
        public int Id { get; set; }
        public MetodoPago Metodo { get; set; }
        public TipoGasto TipoGasto { get; set; }
        public Usuario Usuario { get; set; }
        public string Descripcion { get; set; }
        public double Monto { get; set; }

        public Pago(MetodoPago metodo, TipoGasto tipoGasto, Usuario usuario, string descripcion, double monto)
        {
            Id = siguienteId++;
            Metodo = metodo;
            TipoGasto = tipoGasto;
            Usuario = usuario;
            Descripcion = descripcion;
            Monto = monto;
            
        }

    
        //Validaciones comunes a todos los pagos
        public virtual void Validar()
        {
            if (Usuario == null)
                throw new Exception("El pago debe tener un usuario.");

            if (TipoGasto == null)
                throw new Exception("El pago debe tener un tipo de gasto.");

            if (string.IsNullOrWhiteSpace(Descripcion))
                throw new Exception("La descripción del pago es obligatoria.");

            if (Monto <= 0)
                throw new Exception("El monto debe ser mayor a cero.");
        }

        public abstract double CalcularTotal();

        public abstract bool EsDelMes(int mes, int anio);

        // Por defecto usamos el total (pago único)
        public virtual double MontoParaOrdenar()
        {
            return CalcularTotal();
        }

        public abstract string ObtenerTipo();

        public abstract DateTime ObtenerFecha();


        public int CompareTo(Pago? other)
        {
            return other.CalcularTotal().CompareTo(this.CalcularTotal());
            
        }

    }
}