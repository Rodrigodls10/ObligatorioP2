using System.Security.Cryptography.X509Certificates;

namespace Dominio;

public class Sistema
{
    public List<Equipo> Equipos { get; set; } = new List<Equipo>();
    public List<Usuario> Usuarios { get; set; } = new List<Usuario>();
    public List<TipoGasto> TipoGasto { get; set; } = new List<TipoGasto>();
    public List<Pago> Pagos { get; set; } = new List<Pago>();

    public Sistema()
    {
        PrecargarDatos();
    }


    private void PrecargarDatos()
    {
        DateTime hoy = DateTime.Today;

        // ====== GRUPOS ======
        Equipo g1 = new Equipo(1, "Desarrollo", new List<Usuario>());
        Equipo g2 = new Equipo(2, "Soporte", new List<Usuario>());
        Equipo g3 = new Equipo(3, "Administraci�n", new List<Usuario>());
        Equipo g4 = new Equipo(4, "Marketing", new List<Usuario>());

        // Agregar equipos al sistema
        this.Equipos.Add(g1);
        this.Equipos.Add(g2);
        this.Equipos.Add(g3);
        this.Equipos.Add(g4);

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
        Usuario u20 = new Usuario("Ulises", "Nu�ez", "password123", hoy.AddDays(-10));
        Usuario u21 = new Usuario("Valeria", "Pereyra", "password123", hoy.AddDays(-10));
        Usuario u22 = new Usuario("Walter", "Farias", "password123", hoy.AddDays(-10));

        // Agregar usuarios al sistema
        this.Usuarios.Add(u1);
        this.Usuarios.Add(u2);
        this.Usuarios.Add(u3);
        this.Usuarios.Add(u4);
        this.Usuarios.Add(u5);
        this.Usuarios.Add(u6);
        this.Usuarios.Add(u7);
        this.Usuarios.Add(u8);
        this.Usuarios.Add(u9);
        this.Usuarios.Add(u10);
        this.Usuarios.Add(u11);
        this.Usuarios.Add(u12);
        this.Usuarios.Add(u13);
        this.Usuarios.Add(u14);
        this.Usuarios.Add(u15);
        this.Usuarios.Add(u16);
        this.Usuarios.Add(u17);
        this.Usuarios.Add(u18);
        this.Usuarios.Add(u19);
        this.Usuarios.Add(u20);
        this.Usuarios.Add(u21);
        this.Usuarios.Add(u22);

        // Asignar usuarios a equipos (reparto simple 22 = 6/6/5/5)
        g1.Usuarios.Add(u1); g1.Usuarios.Add(u2); g1.Usuarios.Add(u3); g1.Usuarios.Add(u4); g1.Usuarios.Add(u5); g1.Usuarios.Add(u6);
        g2.Usuarios.Add(u7); g2.Usuarios.Add(u8); g2.Usuarios.Add(u9); g2.Usuarios.Add(u10); g2.Usuarios.Add(u11); g2.Usuarios.Add(u12);
        g3.Usuarios.Add(u13); g3.Usuarios.Add(u14); g3.Usuarios.Add(u15); g3.Usuarios.Add(u16); g3.Usuarios.Add(u17);
        g4.Usuarios.Add(u18); g4.Usuarios.Add(u19); g4.Usuarios.Add(u20); g4.Usuarios.Add(u21); g4.Usuarios.Add(u22);

        // ====== GASTOS ======
        TipoGasto t1 = new TipoGasto(); t1.Nombre = "Servicios"; t1.Descripcion = "Gastos de luz, agua, internet";
        TipoGasto t2 = new TipoGasto(); t2.Nombre = "Transporte"; t2.Descripcion = "Vi�ticos y traslados";
        TipoGasto t3 = new TipoGasto(); t3.Nombre = "Vi�ticos"; t3.Descripcion = "Comidas o estad�as laborales";
        TipoGasto t4 = new TipoGasto(); t4.Nombre = "Suministros"; t4.Descripcion = "Material de oficina";
        TipoGasto t5 = new TipoGasto(); t5.Nombre = "Software"; t5.Descripcion = "Licencias y suscripciones";
        TipoGasto t6 = new TipoGasto(); t6.Nombre = "Hardware"; t6.Descripcion = "Equipos o componentes";
        TipoGasto t7 = new TipoGasto(); t7.Nombre = "Marketing"; t7.Descripcion = "Publicidad y promoci�n";
        TipoGasto t8 = new TipoGasto(); t8.Nombre = "Mantenimiento"; t8.Descripcion = "Reparaciones y mantenimiento";
        TipoGasto t9 = new TipoGasto(); t9.Nombre = "Capacitaci�n"; t9.Descripcion = "Cursos y entrenamientos";
        TipoGasto t10 = new TipoGasto(); t10.Nombre = "Otros"; t10.Descripcion = "Gastos varios";

        // ====== PAGOS �NICOS (17) ======
        PagoUnico p1 = new PagoUnico(MetodoPago.EFECTIVO, t1, u1, "Pago �nico 1", hoy.AddDays(-3), "R001", 1500);
        PagoUnico p2 = new PagoUnico(MetodoPago.DEBITO, t2, u2, "Pago �nico 2", hoy.AddDays(-4), "R002", 1600);
        PagoUnico p3 = new PagoUnico(MetodoPago.CREDITO, t3, u3, "Pago �nico 3", hoy.AddDays(-5), "R003", 1700);
        PagoUnico p4 = new PagoUnico(MetodoPago.DEBITO, t4, u4, "Pago �nico 4", hoy.AddDays(-6), "R004", 1800);
        PagoUnico p5 = new PagoUnico(MetodoPago.EFECTIVO, t5, u5, "Pago �nico 5", hoy.AddDays(-7), "R005", 1900);
        PagoUnico p6 = new PagoUnico(MetodoPago.DEBITO, t6, u6, "Pago �nico 6", hoy.AddDays(-8), "R006", 2000);
        PagoUnico p7 = new PagoUnico(MetodoPago.CREDITO, t7, u7, "Pago �nico 7", hoy.AddDays(-9), "R007", 2100);
        PagoUnico p8 = new PagoUnico(MetodoPago.DEBITO, t8, u8, "Pago �nico 8", hoy.AddDays(-10), "R008", 2200);
        PagoUnico p9 = new PagoUnico(MetodoPago.EFECTIVO, t9, u9, "Pago �nico 9", hoy.AddDays(-11), "R009", 2300);
        PagoUnico p10 = new PagoUnico(MetodoPago.DEBITO, t10, u10, "Pago �nico 10", hoy.AddDays(-12), "R010", 2400);
        PagoUnico p11 = new PagoUnico(MetodoPago.CREDITO, t1, u11, "Pago �nico 11", hoy.AddDays(-13), "R011", 2500);
        PagoUnico p12 = new PagoUnico(MetodoPago.EFECTIVO, t2, u12, "Pago �nico 12", hoy.AddDays(-14), "R012", 2600);
        PagoUnico p13 = new PagoUnico(MetodoPago.EFECTIVO, t3, u13, "Pago �nico 13", hoy.AddDays(-15), "R013", 2700);
        PagoUnico p14 = new PagoUnico(MetodoPago.DEBITO, t4, u14, "Pago �nico 14", hoy.AddDays(-16), "R014", 2800);
        PagoUnico p15 = new PagoUnico(MetodoPago.CREDITO, t5, u15, "Pago �nico 15", hoy.AddDays(-17), "R015", 2900);
        PagoUnico p16 = new PagoUnico(MetodoPago.EFECTIVO, t6, u16, "Pago �nico 16", hoy.AddDays(-18), "R016", 3000);
        PagoUnico p17 = new PagoUnico(MetodoPago.EFECTIVO, t7, u17, "Pago �nico 17", hoy.AddDays(-19), "R017", 3100);

        // Agregar pagos �nicos a la lista
        this.Pagos.Add(p1); this.Pagos.Add(p2); this.Pagos.Add(p3); this.Pagos.Add(p4); this.Pagos.Add(p5);
        this.Pagos.Add(p6); this.Pagos.Add(p7); this.Pagos.Add(p8); this.Pagos.Add(p9); this.Pagos.Add(p10);
        this.Pagos.Add(p11); this.Pagos.Add(p12); this.Pagos.Add(p13); this.Pagos.Add(p14); this.Pagos.Add(p15);
        this.Pagos.Add(p16); this.Pagos.Add(p17);

        // ====== PAGOS RECURRENTES (25) ======
        // 5 TERMINADOS
        PagoRecurrente r1 = new PagoRecurrente(MetodoPago.EFECTIVO, t5, u1, "Suscripci�n cerrada 1", hoy.AddMonths(-10), hoy.AddMonths(-4), true, 1500);
        PagoRecurrente r2 = new PagoRecurrente(MetodoPago.DEBITO, t6, u2, "Suscripci�n cerrada 2", hoy.AddMonths(-9), hoy.AddMonths(-3), true, 1600);
        PagoRecurrente r3 = new PagoRecurrente(MetodoPago.CREDITO, t7, u3, "Suscripci�n cerrada 3", hoy.AddMonths(-8), hoy.AddMonths(-2), true, 1700);
        PagoRecurrente r4 = new PagoRecurrente(MetodoPago.EFECTIVO, t8, u4, "Suscripci�n cerrada 4", hoy.AddMonths(-7), hoy.AddMonths(-1), true, 1800);
        PagoRecurrente r5 = new PagoRecurrente(MetodoPago.EFECTIVO, t9, u5, "Suscripci�n cerrada 5", hoy.AddMonths(-6), hoy.AddMonths(-1), true, 1900);

        // 10 ACTIVAS CON L�MITE
        PagoRecurrente r6 = new PagoRecurrente(MetodoPago.DEBITO, t1, u6, "Suscripci�n activa con fin 1", hoy.AddMonths(-5), hoy.AddMonths(7), true, 1300);
        PagoRecurrente r7 = new PagoRecurrente(MetodoPago.CREDITO, t2, u7, "Suscripci�n activa con fin 2", hoy.AddMonths(-4), hoy.AddMonths(8), true, 1400);
        PagoRecurrente r8 = new PagoRecurrente(MetodoPago.EFECTIVO, t3, u8, "Suscripci�n activa con fin 3", hoy.AddMonths(-3), hoy.AddMonths(9), true, 1500);
        PagoRecurrente r9 = new PagoRecurrente(MetodoPago.EFECTIVO, t4, u9, "Suscripci�n activa con fin 4", hoy.AddMonths(-2), hoy.AddMonths(10), true, 1600);
        PagoRecurrente r10 = new PagoRecurrente(MetodoPago.DEBITO, t5, u10, "Suscripci�n activa con fin 5", hoy.AddMonths(-1), hoy.AddMonths(11), true, 1700);
        PagoRecurrente r11 = new PagoRecurrente(MetodoPago.CREDITO, t6, u11, "Suscripci�n activa con fin 6", hoy.AddMonths(-5), hoy.AddMonths(12), true, 1800);
        PagoRecurrente r12 = new PagoRecurrente(MetodoPago.DEBITO, t7, u12, "Suscripci�n activa con fin 7", hoy.AddMonths(-3), hoy.AddMonths(13), true, 1900);
        PagoRecurrente r13 = new PagoRecurrente(MetodoPago.EFECTIVO, t8, u13, "Suscripci�n activa con fin 8", hoy.AddMonths(-2), hoy.AddMonths(14), true, 2000);
        PagoRecurrente r14 = new PagoRecurrente(MetodoPago.DEBITO, t9, u14, "Suscripci�n activa con fin 9", hoy.AddMonths(-1), hoy.AddMonths(15), true, 2100);
        PagoRecurrente r15 = new PagoRecurrente(MetodoPago.CREDITO, t10, u15, "Suscripci�n activa con fin 10", hoy.AddMonths(-1), hoy.AddMonths(16), true, 2200);

        // 10 SIN L�MITE (usamos una fecha lejana como fin pero con hasEnd=false)
        PagoRecurrente r16 = new PagoRecurrente(MetodoPago.EFECTIVO, t1, u16, "Suscripci�n sin fin 1", hoy.AddMonths(-3), hoy.AddYears(5), false, 1800);
        PagoRecurrente r17 = new PagoRecurrente(MetodoPago.EFECTIVO, t2, u17, "Suscripci�n sin fin 2", hoy.AddMonths(-2), hoy.AddYears(5), false, 1900);
        PagoRecurrente r18 = new PagoRecurrente(MetodoPago.DEBITO, t3, u18, "Suscripci�n sin fin 3", hoy.AddMonths(-1), hoy.AddYears(5), false, 2000);
        PagoRecurrente r19 = new PagoRecurrente(MetodoPago.CREDITO, t4, u19, "Suscripci�n sin fin 4", hoy.AddMonths(-1), hoy.AddYears(5), false, 2100);
        PagoRecurrente r20 = new PagoRecurrente(MetodoPago.CREDITO, t5, u20, "Suscripci�n sin fin 5", hoy.AddMonths(-1), hoy.AddYears(5), false, 2200);
        PagoRecurrente r21 = new PagoRecurrente(MetodoPago.EFECTIVO, t6, u21, "Suscripci�n sin fin 6", hoy.AddMonths(-1), hoy.AddYears(5), false, 2300);
        PagoRecurrente r22 = new PagoRecurrente(MetodoPago.DEBITO, t7, u22, "Suscripci�n sin fin 7", hoy.AddMonths(-1), hoy.AddYears(5), false, 2400);
        PagoRecurrente r23 = new PagoRecurrente(MetodoPago.CREDITO, t8, u1, "Suscripci�n sin fin 8", hoy.AddMonths(-1), hoy.AddYears(5), false, 2500);
        PagoRecurrente r24 = new PagoRecurrente(MetodoPago.DEBITO, t9, u2, "Suscripci�n sin fin 9", hoy.AddMonths(-1), hoy.AddYears(5), false, 2600);
        PagoRecurrente r25 = new PagoRecurrente(MetodoPago.EFECTIVO, t10, u3, "Suscripci�n sin fin 10", hoy.AddMonths(-1), hoy.AddYears(5), false, 2700);

        // Agregar pagos recurrentes a la lista
        this.Pagos.Add(r1); this.Pagos.Add(r2); this.Pagos.Add(r3); this.Pagos.Add(r4); this.Pagos.Add(r5);
        this.Pagos.Add(r6); this.Pagos.Add(r7); this.Pagos.Add(r8); this.Pagos.Add(r9); this.Pagos.Add(r10);
        this.Pagos.Add(r11); this.Pagos.Add(r12); this.Pagos.Add(r13); this.Pagos.Add(r14); this.Pagos.Add(r15);
        this.Pagos.Add(r16); this.Pagos.Add(r17); this.Pagos.Add(r18); this.Pagos.Add(r19); this.Pagos.Add(r20);
        this.Pagos.Add(r21); this.Pagos.Add(r22); this.Pagos.Add(r23); this.Pagos.Add(r24); this.Pagos.Add(r25);
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
            if (p.Usuario.Email == correo)
            {
                ListaUsuariosFiltrados.Add(p);
            }
        }
        return ListaUsuariosFiltrados;
    }


    public void AltaUsuario(Usuario u, string nombreEquipo)
    {
        u.Validar();
        ValidarExistencia(u);
        this.Usuarios.Add(u);

        bool asignado = false;
        foreach (Equipo e in this.Equipos)
        {
            if (e.Nombre == nombreEquipo)
            {
                if (e.Usuarios == null) e.Usuarios = new List<Usuario>();
                e.Usuarios.Add(u);      
                asignado = true;
                break;
            }
        }

        if (!asignado)
        {
            throw new Exception("Equipo no encontrado: " + nombreEquipo);
        }
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
            if (e.Nombre == nombreEquipo)
            {
                equiposFiltrados.Add(e);
            }
        }
        return equiposFiltrados;
    }
}