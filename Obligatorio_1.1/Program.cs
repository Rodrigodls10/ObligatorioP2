namespace Obligatorio_1._1;
using Dominio;
using System;


class Program
{
    static void Main(string[] args)
    {
        Sistema sistema = new Sistema();
        Menu(sistema);



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

            //todos estos metodos hay que ponerlos dentro de un try and catch para poder manejar las excepciones


            if (op == "1")
            {
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
                    
            }
            else if (op == "2")
            {
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
                    ;
                }
                
            }
            else if (op == "3")
            {
                try
                {
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Apellido: ");
                    string apellido = Console.ReadLine();
                    Console.Write("Contraseña (mín 8): ");
                    string contrasena = Console.ReadLine();

                    Console.WriteLine("Equipos disponibles:");
               
                    Console.Write("Equipo: ");
                    List<Equipo> equipos = sistema.ListarEquipos(); // listar equipos disponibles
                    foreach (Equipo e in equipos)
                    {
                        Console.WriteLine(e.Nombre);
                    }

                    string nombreEquipo = Console.ReadLine();
                    Usuario nuevoUsuario  = new Usuario(nombre, apellido, contrasena, DateTime.Now);
                    sistema.AltaUsuario(nuevoUsuario, nombreEquipo); // implementar metodo en sistema
                    Console.WriteLine("Usuario Agregado Exitosamente");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    
                        
                            
                }
                
            }
            else if (op == "4")
            {
                try
                {
                    Console.Write("Nombre de equipo: ");
                    List<Equipo> equiposUser = sistema.ListarEquipos();
                    foreach (Equipo e in equiposUser)
                    {
                        Console.WriteLine(e.Nombre);
                    }
                    
                    string nombreEquipo = Console.ReadLine();
                    List<Equipo> equipos = sistema.ListarUsuarioPorEquipo(nombreEquipo); // listar equipos disponibles
                    foreach (Equipo e in equipos)
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
                    ;
                }
                
                

                
            }
            else if (op == "0")
            {
                seguir = false;
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }
        }
    }
}
