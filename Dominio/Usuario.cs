using System.IO.IsolatedStorage;
using System.Runtime.CompilerServices;

namespace Dominio;

public class Usuario
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Contrasena { get; set; }
    public string Email { get; set; }
    public DateTime FechaIngreso { get; set; }

    public static List<string> EmailsRegistrados = new List<string>(); //Es una lista para guardar los emails generados y evitar duplicados


  



    public Usuario(string nombre, string apellido, string contrasena, DateTime fechaIngreso)
    {
        Nombre = nombre;
        Apellido = apellido;
        Contrasena = contrasena;
        FechaIngreso = fechaIngreso;

        Validar(); // metemos el validar en el constructor para que no se pueda crear un usuario inválido
        Email = GenerarEmail(nombre, apellido);
    }

    public void Validar()
    {
        if (Nombre == null || Nombre == "") throw new Exception("El nombre no puede estar vacío.");
        if (Apellido == null || Apellido == "") throw new Exception("El apellido no puede estar vacío.");
        if (Contrasena == null || Contrasena.Length < 8) throw new Exception("La contraseña debe tener al menos 8 caracteres.");
    }

    private string GenerarEmail(string nombre, string apellido)
    {
        string parteNombre = "";
        string parteApellido = "";

        // si el nombre tiene 3 o más letras, tomamos las primerar 3 letras
        if (nombre.Length >= 3)
        {
            parteNombre = nombre.Substring(0, 3);
        }
        else
        {
            parteNombre = nombre;
        }

        // si el apellido tiene 3 o más letras, tomamos las primerar 3 letras
        if (apellido.Length >= 3)
        {
            parteApellido = apellido.Substring(0, 3);
        }
        else
        {
            parteApellido = apellido;
        }

        string baseEmail = parteNombre + parteApellido + "@laEmpresa.com";
        string emailFinal = baseEmail;
        int numero = 1;

        // verificamos si ya existe el email
        bool existe = true;
        while (existe)
        {
            existe = false;
            foreach (string e in EmailsRegistrados)
            {
                if (e == emailFinal)
                {
                    existe = true;
                    emailFinal = parteNombre + parteApellido + numero + "@laEmpresa.com";
                    numero = numero + 1;
                }
            }
        }

        EmailsRegistrados.Add(emailFinal);
        return emailFinal;
    }


    

    public override string ToString()
    {
        return "Nombre Usuario: " + Nombre + ", Apellido Usuario: " + Apellido + ", Email: " + Email;
    }

    public override bool Equals(object obj)
    {
        Usuario u = (Usuario)obj;
        return u.Email == this.Email;
    }
}




