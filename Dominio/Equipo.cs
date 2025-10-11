using System.Runtime.CompilerServices;

namespace Dominio;


public class Equipo
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    
    public List<Usuario> Usuarios { get; set; }

    public Equipo(int Id, string Nombre, List<Usuario> Usuarios)
    {
        this.Id = Id;
        this.Nombre = Nombre;
        this.Usuarios = Usuarios;
    }

    public override string ToString()
    {
        string resultado = $"Equipo: {Nombre}\n";

        foreach (Usuario u in Usuarios)
        {
            resultado += $"{u.Nombre} - {u.Email}\n";
        }

        return resultado;
    }





}



