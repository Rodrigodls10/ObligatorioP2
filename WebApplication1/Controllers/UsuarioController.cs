using Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

public class UsuarioController : Controller
{
    private Sistema sistema = Sistema.ObtenerInstancia();

    [HttpGet]
    public IActionResult VerPerfil()
    {
        try
        {
            string email = HttpContext.Session.GetString("email");
            if (string.IsNullOrEmpty(email))
            {
                return RedirectToAction("Autenticar", "Login");
            }

            Usuario usuario = sistema.BuscarUsuarioPorEmail(email);
            if (usuario == null)
            {
                return RedirectToAction("Autenticar", "Login");
            }

            DateTime hoy = DateTime.Today;
            int mes = hoy.Month;
            int anio = hoy.Year;

           
            double totalMes = sistema.CalcularMontoGastadoMesUsuario(email, mes, anio);
            Equipo equipo = sistema.BuscarEquipoDeUsuario(usuario);

            ViewBag.MontoMes = totalMes;
            ViewBag.NombreEquipo = equipo != null ? equipo.Nombre : "Sin equipo";

            if (usuario is Gerente)
            {
                var miembros = sistema.ListarMiembrosEquipoOrdenadosPorEmail(usuario);
                ViewBag.MiembrosEquipo = miembros;
            }

            return View(usuario);
        }
        catch (Exception ex)
        {
            ViewBag.Error = ex.Message;
            return View();
        }
    }
}

