using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Dominio;

namespace WebApplication1.Controllers
{
    public class PagoController : Controller
    {
        private Sistema sistema = Sistema.ObtenerInstancia();

        
        public IActionResult MisPagos()
        {
            
            string? email = HttpContext.Session.GetString("email");
            if (email == null || email == "")
            {
               
                return RedirectToAction("Autenticar", "Login");
            }

           
            DateTime hoy = DateTime.Today;
            int mes = hoy.Month;
            int anio = hoy.Year;

           
            List<Pago> pagos = sistema.ListarPagosUsuarioMes(email, mes, anio);

           
            return View(pagos);
        }
    }
}

