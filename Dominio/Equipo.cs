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


    public void AgregarUsuario(Usuario u)
    {
        if (Usuarios == null)
        {
            Usuarios = new List<Usuario>();
        }

        bool yaEsta = false;
        foreach (Usuario ux in Usuarios)
        {
            if (ux.Email == u.Email)
            {
                yaEsta = true;
                break;
            }
        }

        if (yaEsta)
        {
            throw new Exception("El usuario ya pertenece al equipo: " + Nombre);
        }

        Usuarios.Add(u);
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



