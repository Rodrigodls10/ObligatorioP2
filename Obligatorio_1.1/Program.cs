namespace Obligatorio_1._1;
using Dominio;
using System;

class Program
{
    static void Main(string[] args)
    {
        Sistema s = Sistema.ObtenerInstancia();
        Menu(s);
    }

    static void Menu(Sistema sistema)
    {
        bool seguir = true;

        while (seguir)
        {
            Console.WriteLine();
            Console.WriteLine("===== MENÚ =====");
            Console.WriteLine("1) Listar usuarios (nombre, email, equipo)");
            Console.WriteLine("2) Listar pagos por correo");
            Console.WriteLine("3) Alta de usuario (email automático)");
            Console.WriteLine("4) Listar usuarios por equipo");
            Console.WriteLine("0) Salir");
            Console.Write("Opción: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    try
                    {
                        Console.WriteLine("Lista de Usuarios");
                        List<Usuario> usuarios = sistema.ListaUsuarios();
                        foreach (Usuario u in usuarios)
                        {
                            Console.WriteLine(u);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;

                case "2":
                    try
                    {
                        Console.Write("Correo: ");
                        string correo = Console.ReadLine();
                        List<Pago> pagos = sistema.ListarPagosCorreo(correo);
                        Console.WriteLine("Pagos encontrados:");
                        foreach (Pago p in pagos)
                        {
                            Console.WriteLine(p);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;

                case "3":
                    try
                    {
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Apellido: ");
                        string apellido = Console.ReadLine();

                        Console.Write("Contraseña (mín 8): ");
                        string contrasena = Console.ReadLine();

                        Console.WriteLine("Equipos disponibles:");
                        List<Equipo> equipos = sistema.ListarEquipos();
                        foreach (Equipo e in equipos)
                        {
                            Console.WriteLine($"{e.Id}-{e.Nombre}");
                        }

                        Console.Write("Equipo: ");
                        string nombreEquipo = Console.ReadLine();

                        //Usuario nuevoUsuario = new Empleado(nombre, apellido, contrasena, DateTime.Now);

                        // Alta del usuario
                      //  sistema.AltaUsuario(nuevoUsuario);

                        // Asignación al equipo
                       // sistema.AsignarUsuarioAEquipo(nuevoUsuario, nombreEquipo);

                        Console.WriteLine("Usuario agregado exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    break;

                case "4":
                    try
                    {
                        Console.WriteLine("Ingrese el Nombre de Equipo: ");
                        List<Equipo> equiposUser = sistema.ListarEquipos();
                        foreach (Equipo e in equiposUser)
                        {
                            Console.WriteLine(" -------- ");
                            Console.WriteLine($"{e.Id}-{e.Nombre}");
                        }

                        string nombreEquipo = Console.ReadLine();
                        List<Equipo> equiposEncontrados = sistema.ListarUsuarioPorEquipo(nombreEquipo);

                        foreach (Equipo e in equiposEncontrados)
                        {
                            foreach (Usuario u in e.Usuarios)
                            {
                                Console.WriteLine(u);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;

                case "0":
                    seguir = false;
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}
