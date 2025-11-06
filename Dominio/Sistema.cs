using System.Security.Cryptography.X509Certificates;

namespace Dominio;

public class Sistema
{
    private static Sistema instancia;
    public List<Equipo> Equipos { get; set; } = new List<Equipo>();
    public List<Usuario> Usuarios { get; set; } = new List<Usuario>();
   
    public List<Pago> Pagos { get; set; } = new List<Pago>();
    
    public List<TipoGasto> TiposGasto { get; set; } = new List<TipoGasto>();


    private Sistema()
    {
        PrecargarDatos();
    }

    public static Sistema ObtenerInstancia()
    {
        if (instancia == null)
        {
            instancia = new Sistema();
        }
        return instancia;
    }


    private void PrecargarDatos()
    {
        DateTime hoy = DateTime.Today;

        // ====== GRUPOS ======
        Equipo g1 = new Equipo(1, "Desarrollo", new List<Usuario>());
        Equipo g2 = new Equipo(2, "Soporte", new List<Usuario>());
        Equipo g3 = new Equipo(3, "Administracion", new List<Usuario>());
        Equipo g4 = new Equipo(4, "Marketing", new List<Usuario>());

        // Agregar equipos al sistema
        this.AltaEquipo(g1);
        this.AltaEquipo(g2);
        this.AltaEquipo(g3);
        this.AltaEquipo(g4);

        // ====== USUARIOS ======
        Usuario u1 = new Usuario("Ana", "Lopez", "password123", hoy.AddDays(-10));
        Usuario u2 = new Usuario("Bruno", "Silva", "password123", hoy.AddDays(-10));
        Usuario u3 = new Usuario("Camila", "Ramos", "password123", hoy.AddDays(-10));
        Usuario u4 = new Usuario("Diego", "Perez", "password123", hoy.AddDays(-10));
        Usuario u5 = new Usuario("Elena", "Suarez", "password123", hoy.AddDays(-10));
        Usuario u6 = new Usuario("Felipe", "Gomez", "password123", hoy.AddDays(-10));
        Usuario u7 = new Usuario("Gabriela", "Torres", "password123", hoy.AddDays(-10));
        Usuario u8 = new Usuario("Hugo", "Vega", "password123", hoy.AddDays(-10));
        Usuario u9 = new Usuario("Irene", "Mendez", "password123", hoy.AddDays(-10));
        Usuario u10 = new Usuario("Javier", "Martinez", "password123", hoy.AddDays(-10));
        Usuario u11 = new Usuario("Karina", "Acosta", "password123", hoy.AddDays(-10));
        Usuario u12 = new Usuario("Lucas", "Fernandez", "password123", hoy.AddDays(-10));
        Usuario u13 = new Usuario("Marina", "Sosa", "password123", hoy.AddDays(-10));
        Usuario u14 = new Usuario("Nicolas", "Diaz", "password123", hoy.AddDays(-10));
        Usuario u15 = new Usuario("Olga", "Cardozo", "password123", hoy.AddDays(-10));
        Usuario u16 = new Usuario("Pablo", "Castro", "password123", hoy.AddDays(-10));
        Usuario u17 = new Usuario("Rocio", "Cabrera", "password123", hoy.AddDays(-10));
        Usuario u18 = new Usuario("Santiago", "Alvarez", "password123", hoy.AddDays(-10));
        Usuario u19 = new Usuario("Tamara", "Ibarra", "password123", hoy.AddDays(-10));
        Usuario u20 = new Usuario("Ulises", "Nuniez", "password123", hoy.AddDays(-10));
        Usuario u21 = new Usuario("Valeria", "Pereyra", "password123", hoy.AddDays(-10));
        Usuario u22 = new Usuario("Walter", "Farias", "password123", hoy.AddDays(-10));

        // Agregar usuarios al sistema
        this.AltaUsuario(u1);
        this.AltaUsuario(u2);
        this.AltaUsuario(u3);
        this.AltaUsuario(u4);
        this.AltaUsuario(u5);
        this.AltaUsuario(u6);
        this.AltaUsuario(u7);
        this.AltaUsuario(u8);
        this.AltaUsuario(u9);
        this.AltaUsuario(u10);
        this.AltaUsuario(u11);
        this.AltaUsuario(u12);
        this.AltaUsuario(u13);
        this.AltaUsuario(u14);
        this.AltaUsuario(u15);
        this.AltaUsuario(u16);
        this.AltaUsuario(u17);
        this.AltaUsuario(u18);
        this.AltaUsuario(u19);
        this.AltaUsuario(u20);
        this.AltaUsuario(u21);
        this.AltaUsuario(u22);


        // Asignar usuarios a equipos (reparto simple 22 = 6/6/5/5)
        g1.Usuarios.Add(u1); g1.Usuarios.Add(u2); g1.Usuarios.Add(u3); g1.Usuarios.Add(u4); g1.Usuarios.Add(u5); g1.Usuarios.Add(u6);
        g2.Usuarios.Add(u7); g2.Usuarios.Add(u8); g2.Usuarios.Add(u9); g2.Usuarios.Add(u10); g2.Usuarios.Add(u11); g2.Usuarios.Add(u12);
        g3.Usuarios.Add(u13); g3.Usuarios.Add(u14); g3.Usuarios.Add(u15); g3.Usuarios.Add(u16); g3.Usuarios.Add(u17);
        g4.Usuarios.Add(u18); g4.Usuarios.Add(u19); g4.Usuarios.Add(u20); g4.Usuarios.Add(u21); g4.Usuarios.Add(u22);

        // ====== GASTOS ======
        TipoGasto t1 = new TipoGasto(); t1.Nombre = "Servicios"; t1.Descripcion = "Gastos de luz, agua, internet";
        TipoGasto t2 = new TipoGasto(); t2.Nombre = "Transporte"; t2.Descripcion = "Viaticos y traslados";
        TipoGasto t3 = new TipoGasto(); t3.Nombre = "Viaticos"; t3.Descripcion = "Comidas o estad�as laborales";
        TipoGasto t4 = new TipoGasto(); t4.Nombre = "Suministros"; t4.Descripcion = "Material de oficina";
        TipoGasto t5 = new TipoGasto(); t5.Nombre = "Software"; t5.Descripcion = "Licencias y suscripciones";
        TipoGasto t6 = new TipoGasto(); t6.Nombre = "Hardware"; t6.Descripcion = "Equipos o componentes";
        TipoGasto t7 = new TipoGasto(); t7.Nombre = "Marketing"; t7.Descripcion = "Publicidad y promocion";
        TipoGasto t8 = new TipoGasto(); t8.Nombre = "Mantenimiento"; t8.Descripcion = "Reparaciones y mantenimiento";
        TipoGasto t9 = new TipoGasto(); t9.Nombre = "Capacitacion"; t9.Descripcion = "Cursos y entrenamientos";
        TipoGasto t10 = new TipoGasto(); t10.Nombre = "Otros"; t10.Descripcion = "Gastos varios";
        
        this.TiposGasto.Add(t1);
        this.TiposGasto.Add(t2);
        this.TiposGasto.Add(t3);
        this.TiposGasto.Add(t4);
        this.TiposGasto.Add(t5);
        this.TiposGasto.Add(t6);
        this.TiposGasto.Add(t7);
        this.TiposGasto.Add(t8);
        this.TiposGasto.Add(t9);
        this.TiposGasto.Add(t10);

        // ====== PAGOS UNICOS (17) ======
        PagoUnico p1 = new PagoUnico(MetodoPago.EFECTIVO, t1, u1, "Pago unico 1", hoy.AddDays(-3), "R001", 1500);
        PagoUnico p2 = new PagoUnico(MetodoPago.DEBITO, t2, u2, "Pago unico 2", hoy.AddDays(-4), "R002", 1600);
        PagoUnico p3 = new PagoUnico(MetodoPago.CREDITO, t3, u3, "Pago unico 3", hoy.AddDays(-5), "R003", 1700);
        PagoUnico p4 = new PagoUnico(MetodoPago.DEBITO, t4, u4, "Pago unico 4", hoy.AddDays(-6), "R004", 1800);
        PagoUnico p5 = new PagoUnico(MetodoPago.EFECTIVO, t5, u5, "Pago unico 5", hoy.AddDays(-7), "R005", 1900);
        PagoUnico p6 = new PagoUnico(MetodoPago.DEBITO, t6, u6, "Pago unico 6", hoy.AddDays(-8), "R006", 2000);
        PagoUnico p7 = new PagoUnico(MetodoPago.CREDITO, t7, u7, "Pago unico 7", hoy.AddDays(-9), "R007", 2100);
        PagoUnico p8 = new PagoUnico(MetodoPago.DEBITO, t8, u8, "Pago unico 8", hoy.AddDays(-10), "R008", 2200);
        PagoUnico p9 = new PagoUnico(MetodoPago.EFECTIVO, t9, u9, "Pago unico 9", hoy.AddDays(-11), "R009", 2300);
        PagoUnico p10 = new PagoUnico(MetodoPago.DEBITO, t10, u10, "Pago unico 10", hoy.AddDays(-12), "R010", 2400);
        PagoUnico p11 = new PagoUnico(MetodoPago.CREDITO, t1, u11, "Pago unico 11", hoy.AddDays(-13), "R011", 2500);
        PagoUnico p12 = new PagoUnico(MetodoPago.EFECTIVO, t2, u12, "Pago unico 12", hoy.AddDays(-14), "R012", 2600);
        PagoUnico p13 = new PagoUnico(MetodoPago.EFECTIVO, t3, u13, "Pago unico 13", hoy.AddDays(-15), "R013", 2700);
        PagoUnico p14 = new PagoUnico(MetodoPago.DEBITO, t4, u14, "Pago unico 14", hoy.AddDays(-16), "R014", 2800);
        PagoUnico p15 = new PagoUnico(MetodoPago.CREDITO, t5, u15, "Pago unico 15", hoy.AddDays(-17), "R015", 2900);
        PagoUnico p16 = new PagoUnico(MetodoPago.EFECTIVO, t6, u16, "Pago unico 16", hoy.AddDays(-18), "R016", 3000);
        PagoUnico p17 = new PagoUnico(MetodoPago.EFECTIVO, t7, u17, "Pago unico 17", hoy.AddDays(-19), "R017", 3100);

        // Agregar pagos Unicos a la lista
        this.AltaPago(p1); this.AltaPago(p2); this.AltaPago(p3); this.AltaPago(p4); this.AltaPago(p5);
        this.AltaPago(p6); this.AltaPago(p7); this.AltaPago(p8); this.AltaPago(p9); this.AltaPago(p10);
        this.AltaPago(p11); this.AltaPago(p12); this.AltaPago(p13); this.AltaPago(p14); this.AltaPago(p15);
        this.AltaPago(p16); this.AltaPago(p17);


        // ====== PAGOS RECURRENTES (25) ======
        // 5 TERMINADOS
        PagoRecurrente r1 = new PagoRecurrente(MetodoPago.EFECTIVO, t5, u1, "Suscripcion cerrada 1", hoy.AddMonths(-10), hoy.AddMonths(-4), true, 1500);
        PagoRecurrente r2 = new PagoRecurrente(MetodoPago.DEBITO, t6, u2, "Suscripcion cerrada 2", hoy.AddMonths(-9), hoy.AddMonths(-3), true, 1600);
        PagoRecurrente r3 = new PagoRecurrente(MetodoPago.CREDITO, t7, u3, "Suscripcion cerrada 3", hoy.AddMonths(-8), hoy.AddMonths(-2), true, 1700);
        PagoRecurrente r4 = new PagoRecurrente(MetodoPago.EFECTIVO, t8, u4, "Suscripcion cerrada 4", hoy.AddMonths(-7), hoy.AddMonths(-1), true, 1800);
        PagoRecurrente r5 = new PagoRecurrente(MetodoPago.EFECTIVO, t9, u5, "Suscripcion cerrada 5", hoy.AddMonths(-6), hoy.AddMonths(-1), true, 1900);

        // 10 ACTIVAS CON LIMITE
        PagoRecurrente r6 = new PagoRecurrente(MetodoPago.DEBITO, t1, u6, "Suscripcion activa con fin 1", hoy.AddMonths(-5), hoy.AddMonths(7), true, 1300);
        PagoRecurrente r7 = new PagoRecurrente(MetodoPago.CREDITO, t2, u7, "Suscripcion activa con fin 2", hoy.AddMonths(-4), hoy.AddMonths(8), true, 1400);
        PagoRecurrente r8 = new PagoRecurrente(MetodoPago.EFECTIVO, t3, u8, "Suscripcion activa con fin 3", hoy.AddMonths(-3), hoy.AddMonths(9), true, 1500);
        PagoRecurrente r9 = new PagoRecurrente(MetodoPago.EFECTIVO, t4, u9, "Suscripcion activa con fin 4", hoy.AddMonths(-2), hoy.AddMonths(10), true, 1600);
        PagoRecurrente r10 = new PagoRecurrente(MetodoPago.DEBITO, t5, u10, "Suscripcion activa con fin 5", hoy.AddMonths(-1), hoy.AddMonths(11), true, 1700);
        PagoRecurrente r11 = new PagoRecurrente(MetodoPago.CREDITO, t6, u11, "Suscripcion activa con fin 6", hoy.AddMonths(-5), hoy.AddMonths(12), true, 1800);
        PagoRecurrente r12 = new PagoRecurrente(MetodoPago.DEBITO, t7, u12, "Suscripcion activa con fin 7", hoy.AddMonths(-3), hoy.AddMonths(13), true, 1900);
        PagoRecurrente r13 = new PagoRecurrente(MetodoPago.EFECTIVO, t8, u13, "Suscripcion activa con fin 8", hoy.AddMonths(-2), hoy.AddMonths(14), true, 2000);
        PagoRecurrente r14 = new PagoRecurrente(MetodoPago.DEBITO, t9, u14, "Suscripcion activa con fin 9", hoy.AddMonths(-1), hoy.AddMonths(15), true, 2100);
        PagoRecurrente r15 = new PagoRecurrente(MetodoPago.CREDITO, t10, u15, "Suscripcion activa con fin 10", hoy.AddMonths(-1), hoy.AddMonths(16), true, 2200);

        // 10 SIN LIMITE (usamos una fecha lejana como fin pero con hasEnd=false)
        PagoRecurrente r16 = new PagoRecurrente(MetodoPago.EFECTIVO, t1, u16, "Suscripcion sin fin 1", hoy.AddMonths(-3), hoy.AddYears(5), false, 1800);
        PagoRecurrente r17 = new PagoRecurrente(MetodoPago.EFECTIVO, t2, u17, "Suscripcion sin fin 2", hoy.AddMonths(-2), hoy.AddYears(5), false, 1900);
        PagoRecurrente r18 = new PagoRecurrente(MetodoPago.DEBITO, t3, u18, "Suscripcion sin fin 3", hoy.AddMonths(-1), hoy.AddYears(5), false, 2000);
        PagoRecurrente r19 = new PagoRecurrente(MetodoPago.CREDITO, t4, u19, "Suscripcion sin fin 4", hoy.AddMonths(-1), hoy.AddYears(5), false, 2100);
        PagoRecurrente r20 = new PagoRecurrente(MetodoPago.CREDITO, t5, u20, "Suscripcion sin fin 5", hoy.AddMonths(-1), hoy.AddYears(5), false, 2200);
        PagoRecurrente r21 = new PagoRecurrente(MetodoPago.EFECTIVO, t6, u21, "Suscripcion sin fin 6", hoy.AddMonths(-1), hoy.AddYears(5), false, 2300);
        PagoRecurrente r22 = new PagoRecurrente(MetodoPago.DEBITO, t7, u22, "Suscripcion sin fin 7", hoy.AddMonths(-1), hoy.AddYears(5), false, 2400);
        PagoRecurrente r23 = new PagoRecurrente(MetodoPago.CREDITO, t8, u1, "Suscripcion sin fin 8", hoy.AddMonths(-1), hoy.AddYears(5), false, 2500);
        PagoRecurrente r24 = new PagoRecurrente(MetodoPago.DEBITO, t9, u2, "Suscripcion sin fin 9", hoy.AddMonths(-1), hoy.AddYears(5), false, 2600);
        PagoRecurrente r25 = new PagoRecurrente(MetodoPago.EFECTIVO, t10, u3, "Suscripcion sin fin 10", hoy.AddMonths(-1), hoy.AddYears(5), false, 2700);

        // Agregar pagos recurrentes a la lista
        this.AltaPago(r1); this.AltaPago(r2); this.AltaPago(r3); this.AltaPago(r4); this.AltaPago(r5);
        this.AltaPago(r6); this.AltaPago(r7); this.AltaPago(r8); this.AltaPago(r9); this.AltaPago(r10);
        this.AltaPago(r11); this.AltaPago(r12); this.AltaPago(r13); this.AltaPago(r14); this.AltaPago(r15);
        this.AltaPago(r16); this.AltaPago(r17); this.AltaPago(r18); this.AltaPago(r19); this.AltaPago(r20);
        this.AltaPago(r21); this.AltaPago(r22); this.AltaPago(r23); this.AltaPago(r24); this.AltaPago(r25);
    }
    



    public List<Usuario> ListaUsuarios()
    {
        List<Usuario> usuariosTotales = new List<Usuario>();
        foreach(Usuario u in this.Usuarios)
        {
            usuariosTotales.Add(u);
        }
        return usuariosTotales;
    }
    



    public List<Pago> ListarPagosCorreo(string correo) 
    { 
        List<Pago> ListaUsuariosFiltrados = new List<Pago>();
        foreach (Pago p in this.Pagos)
        {
            if (p.Usuario.Email.ToLower() == correo.ToLower())
            {
                ListaUsuariosFiltrados.Add(p);
            }
        }
        return ListaUsuariosFiltrados;
    }


    public void AltaUsuario(Usuario u)
    {
        string emailGenerado = GenerarEmail(u.Nombre, u.Apellido);
        u.Email = emailGenerado;
        
        u.Validar();
        ValidarExistencia(u);
        this.Usuarios.Add(u);

        
    }

    public void AsignarUsuarioAEquipo(Usuario u, string nombreEquipo)
    {
        bool asignado = false;

        foreach (Equipo e in this.Equipos)
        {
            if (e.Nombre != null && nombreEquipo != null && e.Nombre.ToLower() == nombreEquipo.ToLower())
            {
                e.AgregarUsuario(u);
                asignado = true;
                break;
            }
        }

        if (!asignado)
        {
            throw new Exception("Equipo no encontrado: " + nombreEquipo);
        }
    }



    private string GenerarEmail(string nombre, string apellido)
    {
        string parteNombre = "";
        string parteApellido = "";

        if (nombre.Length >= 3)
        {
            parteNombre = nombre.Substring(0, 3);
        }
        else
        {
            parteNombre = nombre;
        }

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

        bool existe = true;
        while (existe)
        {
            existe = false;
            foreach (Usuario u in this.Usuarios)
            {
                if (u.Email == emailFinal)
                {
                    existe = true;
                    emailFinal = parteNombre + parteApellido + numero + "@laEmpresa.com";
                    numero++;
                }
            }
        }

        return emailFinal;
    }


    private void ValidarExistencia(Usuario u)
    {
        if (this.Usuarios.Contains(u))
        {
            throw new Exception("Usuario existente");
        }
    }
    public List<Equipo> ListarEquipos()
    {
        return this.Equipos;
    }

    public List<Equipo> ListarUsuarioPorEquipo(string nombreEquipo)
    {
        List<Equipo> equiposFiltrados = new List<Equipo>();
        foreach (Equipo e in this.Equipos)
        {
            if (e.Nombre.ToLower() == nombreEquipo.ToLower())
            {
                equiposFiltrados.Add(e);
            }
        }

        if (equiposFiltrados.Count == 0)
        {
            throw new Exception("No se encontró ningún equipo con el nombre: " + nombreEquipo);
        }

        return equiposFiltrados;
    }

    public void AltaEquipo(Equipo e)
    {
        if (e == null)
        {
            throw new Exception("Equipo inválido.");
        }
        if (e.Nombre == null || e.Nombre == "")
        {
            throw new Exception("El nombre del equipo no puede estar vacío.");
        }

        // Validar duplicado 
        foreach (Equipo existente in this.Equipos)
        {
            if (existente.Id == e.Id) // Validacion por id
            {
                throw new Exception("Ya existe un equipo con el mismo ID.");
            }
        }

        // Validar duplicado por nombre 
        foreach (Equipo existente in this.Equipos)
        {
            if (existente.Nombre != null && e.Nombre != null && existente.Nombre.ToLower() == e.Nombre.ToLower())
            {
                throw new Exception("Ya existe un equipo con el mismo nombre.");
            }
        }

        this.Equipos.Add(e);
    }

    public void AltaPago(Pago p)
    {
        if (p == null)
        {
            throw new Exception("Pago inválido.");
        }
        if (p.Usuario == null)
        {
            throw new Exception("El pago debe tener un usuario asociado.");
        }

        // Validar que el usuario del pago exista en el sistema (por referencia o por email)
        bool existeUsuario = false;
        foreach (Usuario u in this.Usuarios)
        {
            if (object.ReferenceEquals(u, p.Usuario))
            {
                existeUsuario = true;
                break;
            }
            if (u.Email != null && p.Usuario.Email != null && u.Email.ToLower() == p.Usuario.Email.ToLower())
            {
                existeUsuario = true;
                break;
            }
        }

        if (!existeUsuario)
        {
            throw new Exception("El usuario del pago no está dado de alta en el sistema.");
        }

        this.Pagos.Add(p);
    }
    public void AltaTipoGasto(TipoGasto tg)
    {
        if (tg == null)
        {
            throw new Exception("Tipo de gasto inválido");
        }

        if (string.IsNullOrWhiteSpace(tg.Nombre))
        {
            throw new Exception("El nombre es obligatorio");
        }

        // revisar que no exista uno con el mismo nombre
        bool existe = false;
        foreach (TipoGasto existente in this.TiposGasto)
        {
            if (existente.Nombre.ToLower() == tg.Nombre.ToLower())
            {
                existe = true;
            }
        }

        if (existe)
        {
            throw new Exception("Ya existe un tipo de gasto con ese nombre.");
        }

        this.TiposGasto.Add(tg);
    }



}