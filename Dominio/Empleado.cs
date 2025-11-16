namespace Dominio;

public class Empleado : Usuario
{
    public Empleado(string nombre, string apellido, string contrasena, DateTime fechaIngreso)
        : base(nombre, apellido, contrasena, fechaIngreso)
    {
  
    }
    
    public override string ToString()
    {
        return $"Empleado {this.Nombre} {this.Apellido} ";
    }

   

    public override string Rol()
    {
        return "Empleado";
    }
}