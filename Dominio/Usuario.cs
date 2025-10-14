using System.IO.IsolatedStorage;
using System.Runtime.CompilerServices;

namespace Dominio
{  
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contrasena { get; set; }
        public string Email { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Usuario(string nombre, string apellido, string contrasena, DateTime fechaIngreso)
        {
            Nombre = nombre;
            Apellido = apellido;
            Contrasena = contrasena;
            FechaIngreso = fechaIngreso;

            Validar(); // se valida el usuario al crear el email 
            
        }

        public void Validar()
        {
            if (Nombre == null || Nombre == "") throw new Exception("El nombre no puede estar vac�o.");
            if (Apellido == null || Apellido == "") throw new Exception("El apellido no puede estar vac�o.");
            if (Contrasena == null || Contrasena.Length < 8) throw new Exception("La contrase�a debe tener al menos 8 caracteres.");
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
}




