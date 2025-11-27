namespace Dominio;

public class Sistema
{
    public List<Equipo> Equipos { get; private set; } = new List<Equipo>();
    public List<Usuario> Usuarios { get; private set; } = new List<Usuario>();
    public List<Gasto> TiposGasto { get; private set; } = new List<Gasto>();

    public Sistema()
    {
        precargarDatos();
    }

    private void precargarDatos()
    {
        Equipo equipo1 = new Equipo(1,"Equipo A", new List<Usuario>());
        Equipo equipo2 = new Equipo(2,"Equipo B", new List<Usuario>());
        Equipos.Add(equipo1);
        Equipos.Add(equipo2);
        
        Usuario usuario1 = new Usuario("Juan", "Perez", "juan123", "juanper@laempresa.com", new DateTime(2023, 5, 11), null);
        Usuario usuario2 = new Usuario("Maria", "Gomez", "maria123", "mariag@laempresa.com", new DateTime(2023, 6, 1), null);

        Usuarios.Add(usuario1);
        Usuarios.Add(usuario2);
        
        equipo1.Usuarios.Add(usuario1);
        equipo2.Usuarios.Add(usuario2);
        
        
        usuario1.Equipo = equipo1;

        usuario2.Equipo = equipo2;
    }

    public List<Usuario> ListaUsuarios()
    {
        return this.Usuarios;
        

        
    }

    public void AgregarUsuario(Usuario u)
    {
        u.Validar();
        ValidarExistencia(u);
        this.Usuarios.Add(u);
    }

    private void ValidarExistencia(Usuario u)
    {
        if (this.Usuarios.Contains(u))
        {
            throw new Exception("Usuario existente");
        }
    }
}