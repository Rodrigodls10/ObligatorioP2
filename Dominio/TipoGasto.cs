using System.Runtime.CompilerServices;

namespace Dominio;

public class TipoGasto
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    
    public TipoGasto() { }

    public TipoGasto(string nombre, string descripcion)
    {
        Nombre = nombre;
        Descripcion = descripcion;
    }
    
    
}

