namespace Dominio;

public abstract class Pago
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

        if (Usuario == null)
        {
            throw new Exception("El pago debe tener un usuario.");
        }

        if (TipoGasto == null)
        {
            throw new Exception("El pago debe tener un tipo de gasto.");
        }

        if (Monto <= 0)
        {
            throw new Exception("El monto debe ser mayor a cero.");
        }
    }

    //Estos metodos los vamos a sobreescribir en las clases hijas y los vamos a implementar en sistema
  

    public abstract double CalcularTotal();

    public abstract double CalcularTotal();

 
    public abstract bool EsDelMes(int mes, int anio);

    // Por defecto usamos el total (pago único)
    public virtual double MontoParaOrdenar()
    {
        return CalcularTotal();
    }



}