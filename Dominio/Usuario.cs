using System.IO.IsolatedStorage;
using System.Runtime.CompilerServices;

namespace Dominio;

public class Usuario
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Contrasena { get; set; }
    public string Email { get; private set; }
    public DateTime FechaIngreso { get; set; }
    public Equipo Equipo { get; set; }

    public Usuario(string nombre, string apellido, string contrasena, string email, DateTime fechaIngreso,
        Equipo equipo)
    {
        Nombre = nombre;
        Apellido = apellido;
        Contrasena = contrasena;    
        Email = email;
        FechaIngreso = fechaIngreso;
        Equipo = equipo;
    }

    public void Validar()
    {
        if (this.Nombre == "")
        {
            throw new Exception("El nombre no puede estar vacio");
        }
    }

    public override string ToString()
    {
        return "Nombre Usuario: " + this.Nombre + ", Apellido Usuario: " + this.Apellido + ", Email: " + this.Email +
               ", Equipo: " + this.Equipo.Nombre;
    }

    public override bool Equals(object? obj)
    {
        Usuario u = (Usuario)obj;
        return u.Email == this.Email;
    }
}
