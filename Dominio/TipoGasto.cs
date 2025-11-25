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

    public override bool Equals(object obj)
    {
        TipoGasto tipoGasto = (TipoGasto) obj;
        return this.Nombre == tipoGasto.Nombre;
    }
    
    
}

