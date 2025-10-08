namespace Obligatorio_1._1;
using Dominio;


class Program
{
    static void Main(string[] args)
    {
        Sistema sistema = new Sistema();
        
        foreach (Usuario u in sistema.ListaUsuarios())
        {
            Console.WriteLine(u); 
        }
        
        Console.WriteLine("Ingrese un usuario");
        
        string nombre = Console.ReadLine();
        string apellidos = Console.ReadLine();
        string email = Console.ReadLine();
        string contrasena = Console.ReadLine();
        DateTime fechaIngreso = DateTime.Now;
        Console.WriteLine("Seleccione un equipo escribiendo su nombre:");
        foreach (Equipo eq in sistema.Equipos)
        {
            Console.WriteLine("- " + eq.Nombre);
        }
        string nombreEquipo = Console.ReadLine();

        Equipo equipoSeleccionado = null;

        // Buscar el equipo con un foreach
        foreach (Equipo eq in sistema.Equipos)
        {
            if (eq.Nombre == nombreEquipo)
            {
                equipoSeleccionado = eq;
                break; // encontramos el equipo, salimos del foreach
            }
        }

        // Si no encontró coincidencia, asignar un equipo por defecto
        if (equipoSeleccionado == null)
        {
            Console.WriteLine("No se encontró el equipo. Se asignará el primer equipo por defecto.");
            equipoSeleccionado = sistema.Equipos[0];
        }

        Usuario usuarioNuevo = new Usuario(nombre, apellidos, contrasena, email, fechaIngreso, equipoSeleccionado);
        
        sistema.AgregarUsuario(usuarioNuevo);
        foreach (Usuario u in sistema.ListaUsuarios())
        {
            Console.WriteLine(u); 
        }

       

    }
}