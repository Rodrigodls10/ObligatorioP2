namespace Obligatorio_1._1;
using Dominio;


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

            if (op == "1")
            {
                sistema.ImprimirUsuarios();                // implementar metodo en sistema
            }
            else if (op == "2")
            {
                Console.Write("Correo: ");
                string correo = Console.ReadLine();
                sistema.ImprimirPagosPorCorreo(correo);   // implementar metodo en sistema
            }
            else if (op == "3")
            {
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Apellido: ");
                string apellido = Console.ReadLine();
                Console.Write("Contraseña (mín 8): ");
                string contrasena = Console.ReadLine();

                Console.WriteLine("Equipos disponibles:");
                sistema.ImprimirNombresEquipos();          // lista equipos hacerlo en sistema
                Console.Write("Equipo: ");
                string nombreEquipo = Console.ReadLine();

                sistema.AltaUsuarioConEmailAuto(nombre, apellido, contrasena, nombreEquipo);
            }
            else if (op == "4")
            {
                Console.Write("Nombre de equipo: ");
                string nombreEquipo = Console.ReadLine();
                sistema.ImprimirUsuariosPorEquipo(nombreEquipo); // hacerlo en sistema
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
