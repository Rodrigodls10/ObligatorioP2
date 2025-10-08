namespace Dominio;

public class Pago
{
    public static int siguienteId = 1;
    public int Id { get; set; }
    public MetodoPago Metodo { get; set; }

    public TipoGasto TipoGasto { get; set; }

    public Usuario Usuario { get; set; }

    public string Descripcion { get; set; }


    public Pago(MetodoPago metodo, TipoGasto tipoGasto, Usuario usuario, string descripcion)
    {
        Id = siguienteId++;
        Metodo = metodo;
        TipoGasto = tipoGasto;
        Usuario = usuario;
        Descripcion = descripcion;
    }
}