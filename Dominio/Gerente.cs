namespace Dominio;

public class Gerente : Usuario
{
    
    public Gerente(string nombre, string apellido, string contrasena, DateTime fechaIngreso)
        : base(nombre, apellido, contrasena, fechaIngreso)
    {
        
    }

    public override string ToString()
    {
        return $"Gerente {this.Nombre} {this.Apellido} ";
    }

    public override string Rol()
    {
        return "Gerente";
    }
}